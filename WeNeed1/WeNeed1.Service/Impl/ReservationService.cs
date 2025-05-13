using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Enums;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl;
public class ReservationService: BaseCRUDService<ReservationResponseDto, Reservation, ReservationSearchObject, ReservationRequestDto, ReservationRequestDto>, IReservationService
{
    
    private readonly IUserService _userService;

    public ReservationService(WeNeed1Context context, IMapper mapper, IUserService userService) : base(context, mapper)
    {
        _userService = userService;
    }
    
    public override async Task<ReservationResponseDto> Insert(ReservationRequestDto request)
    {
        var sportsField = await _context.SportsFields
            .Include(sf => sf.SportsCenter)
            .FirstOrDefaultAsync(sf => sf.Id == request.SportsFieldId);

        if (sportsField == null)
        {
            throw new Exception("Invalid Sports Field ID.");
        }
        
        var startTime = request.StartTime;
        var endTime = startTime.AddHours(1);
        
        if (startTime.TimeOfDay < sportsField.SportsCenter.StartTime || endTime.TimeOfDay > sportsField.SportsCenter.EndTime)
        {
            throw new Exception("Reservation time is outside working hours.");
        }
        
        var existingReservation = await _context.Reservations.AnyAsync(r =>
            r.SportsFieldId == request.SportsFieldId &&
            r.StartTime == request.StartTime);

        if (existingReservation)
        {
            throw new Exception("Selected time slot is already booked.");
        }
        
        var user = _userService.GetCurrentUserAsync().Result; ; 
        
        var totalPrice = sportsField.PricePerHour;
        
        var entity = new Reservation
        {
            UserId = user.Id,
            SportsFieldId = request.SportsFieldId,
            StartTime = startTime,
            EndTime = endTime,
            TotalPrice = totalPrice,
            Status = ReservationStatus.CREATED,
        };

        _context.Reservations.Add(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<ReservationResponseDto>(entity);
    }
    
    public override IQueryable<Reservation> AddFilter(IQueryable<Reservation> query, ReservationSearchObject search)
    {
        if (search.SportsFieldId.HasValue)
        {
            query = query.Where(r => r.SportsFieldId == search.SportsFieldId.Value);
        }

        if (search.SportsCenterId.HasValue)
        {
            query = query.Where(r => r.SportsField.SportsCenterId == search.SportsCenterId.Value);
        }
        
        if (search.Status.HasValue)
        {
            query = query.Where(r => r.Status == search.Status.Value);
        }

        return query
            .Include(r => r.SportsField)
            .Include(r => r.User);
    }
    
    public List<TimeSpan> GetAvailableSlots(int sportsFieldId, DateTime date)
    {
        var sportsField = _context.SportsFields
            .Include(sf => sf.SportsCenter)
            .FirstOrDefault(sf => sf.Id == sportsFieldId);

        if (sportsField == null)
            throw new Exception("Sports field not found.");

        var startTime = sportsField.SportsCenter.StartTime;
        var endTime = sportsField.SportsCenter.EndTime;
        
        var reservedSlots = _context.Reservations
            .Where(r => r.SportsFieldId == sportsFieldId &&
                        r.StartTime.Date == date.Date)
            .Select(r => r.StartTime.TimeOfDay)
            .ToHashSet();

        var availableSlots = new List<TimeSpan>();

        for (var time = startTime; time < endTime; time = time.Add(TimeSpan.FromHours(1)))
        {
            if (!reservedSlots.Contains(time))
                availableSlots.Add(time);
        }

        return availableSlots;
    }
    
    public async Task<ReservationResponseDto> CancelReservation(int id, string? cancellationReason)
    {
        var reservation = await _context.Reservations.FindAsync(id);
        if (reservation == null)
        {
            throw new Exception("Reservation not found.");
        }

        if (reservation.Status != ReservationStatus.CREATED)
        {
            throw new Exception("Only reservations in 'CREATED' status can be cancelled.");
        }

        reservation.Status = ReservationStatus.CANCELLED;
        reservation.CancellationReason = cancellationReason;

        await _context.SaveChangesAsync();
        return _mapper.Map<ReservationResponseDto>(reservation);
    }


    public async Task<ReservationResponseDto> FinishReservation(int id)
    {
        var reservation = await _context.Reservations.FindAsync(id);
        if (reservation == null)
        {
            throw new Exception("Reservation not found.");
        }

        if (reservation.Status != ReservationStatus.CREATED)
        {
            throw new Exception("Only created reservations can be marked as finished.");
        }

        reservation.Status = ReservationStatus.FINISHED;

        await _context.SaveChangesAsync();
        return _mapper.Map<ReservationResponseDto>(reservation);
    }
    
    public async Task<ReservationResponseDto> PayReservation(int id)
    {
        var reservation = await _context.Reservations.FindAsync(id);
        if (reservation == null)
        {
            throw new Exception("Reservation not found.");
        }

        if (reservation.Status != ReservationStatus.CREATED)
        {
            throw new Exception("Only created reservations can be marked as payed.");
        }

        reservation.Status = ReservationStatus.PAYED;

        await _context.SaveChangesAsync();
        return _mapper.Map<ReservationResponseDto>(reservation);
    }
    
    public async Task<List<ManagerReportDto>> GetReportForManagerAsync()
    {
        var manager = await _userService.GetCurrentUserAsync();

        var sportsCenter = await _context.SportsCenters
            .FirstOrDefaultAsync(sc => sc.ManagerId == manager.Id);

        if (sportsCenter == null)
            throw new Exception("Manager does not have a sports center.");

        var reservations = await _context.Reservations
            .Include(r => r.User)
            .Include(r => r.SportsField)
            .Where(r =>
                r.SportsField.SportsCenterId == sportsCenter.Id &&
                (r.Status == ReservationStatus.PAYED || r.Status == ReservationStatus.FINISHED))
            .ToListAsync();

        var grouped = reservations
            .GroupBy(r => r.User)
            .Select(g => new ManagerReportDto()
            {
                UserName = g.Key.UserName,
                FirstName = g.Key.FirstName,
                LastName = g.Key.LastName,
                ReservationCount = g.Count(),
                TotalAmount = g.Sum(r => r.TotalPrice),
                Reservations = _mapper.Map<List<ReservationResponseDto>>(g.ToList())
            }).ToList();

        return grouped;
    }
    
    public async Task<PlayerReportResponseDto> GetPlayerReport(PlayerReportSearchDto search)
    {
        var user = await _context.Users.FindAsync(search.UserId);
        if (user == null)
            throw new Exception("User not found");

        var query = _context.Reservations
            .Include(r => r.SportsField)
            .Where(r => r.UserId == search.UserId &&
                        (r.Status == ReservationStatus.PAYED || r.Status == ReservationStatus.FINISHED));

        if (search.ReportType == ReportType.MONTHLY && search.Month.HasValue)
        {
            query = query.Where(r => r.StartTime.Year == search.Year && r.StartTime.Month == search.Month.Value);
        }
        else if (search.ReportType == ReportType.YEARLY)
        {
            query = query.Where(r => r.StartTime.Year == search.Year);
        }

        var reservations = await query.ToListAsync();
    
        return new PlayerReportResponseDto
        {
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            TotalReservations = reservations.Count,
            TotalAmount = reservations.Sum(r => r.TotalPrice),
            Reservations = _mapper.Map<List<ReservationResponseDto>>(reservations)
        };
    }
    
}
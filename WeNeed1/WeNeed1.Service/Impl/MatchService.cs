using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeNeed1.Model;
using WeNeed1.Model.Enums;
using WeNeed1.Model.Exceptions;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl;

public class MatchService : BaseCRUDService<MatchResponseDto, Match, MatchSearchObject, MatchRequestDto, MatchRequestDto>, IMatchService
{
    private readonly IUserService _userService;
    public MatchService(WeNeed1Context context, IMapper mapper, IUserService userService) : base(context, mapper) {
        _userService = userService;
    }

    public override async Task<MatchResponseDto> Insert(MatchRequestDto request)
    {
        var teamExists = await _context.Teams.AnyAsync(t => t.Id == request.TeamId);
        if (!teamExists)
        {
            throw new UserException("Invalid TeamId: Team does not exist.");
        }
        var entity = _mapper.Map<Match>(request);
        
        entity.Result = "0:0";
        entity.Status = MatchStatus.CREATED;

        await _context.Matches.AddAsync(entity);
        await _context.SaveChangesAsync();

        return _mapper.Map<MatchResponseDto>(entity);
    }

    public override async Task<PageResult<MatchResponseDto>> Get(MatchSearchObject search = null)
    {
        var query = AddFilter(_context.Matches.Include(x => x.MatchAttendances), search);
        var list = await query.ToListAsync();
        var user = await _userService.GetCurrentUserAsync();
        var userId = user.Id;

        var mapped = list.Select(match => new MatchResponseDto
        {
            Id = match.Id,
            TeamId = match.TeamId,
            MatchDate = match.MatchDate,
            Result = match.Result,
            Status = match.Status,
            AttendingCount = match.MatchAttendances.Count(x => x.IsAttending),
            NotAttendingCount = match.MatchAttendances.Count(x => !x.IsAttending),
            IsCurrentUserAttending = match.MatchAttendances
                .FirstOrDefault(x => x.UserId == userId)?.IsAttending
        }).ToList();

        return new PageResult<MatchResponseDto>
        {
            Result = mapped,
            Count = mapped.Count
        };
    }


    public override async Task<MatchResponseDto> GetById(int id)
    {
        var entity = await _context.Matches
            .Include(m => m.MatchAttendances)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (entity == null)
            throw new UserException("Match not found.");

        var dto = _mapper.Map<MatchResponseDto>(entity);

        var currentUser = _userService.GetCurrentUserAsync();


        dto.AttendingCount = entity.MatchAttendances.Count(a => a.IsAttending);
        dto.NotAttendingCount = entity.MatchAttendances.Count(a => !a.IsAttending);
        dto.IsCurrentUserAttending = entity.MatchAttendances
            .FirstOrDefault(a => a.UserId == currentUser.Id)?.IsAttending;

        return dto;
    }
    public override IQueryable<Match> AddFilter(IQueryable<Match> query, MatchSearchObject search)
    {
            query = query
        .Include(m => m.MatchAttendances)
        .Include(m => m.Team);

        if (search.TeamId.HasValue)
        {
            query = query.Where(m => m.TeamId == search.TeamId.Value);
        }

        if (search.Status.HasValue)
        {
            query = query.Where(m => m.Status == search.Status.Value);
        }

        return query;
    }


    public async Task SetAttendance(int matchId, int userId, bool isAttending)
    {
        var match = await _context.Matches
            .Include(m => m.MatchAttendances)
            .FirstOrDefaultAsync(m => m.Id == matchId);

        if (match == null)
            throw new UserException("Match not found");

        var existing = match.MatchAttendances.FirstOrDefault(x => x.UserId == userId);
        if (existing != null)
        {
            existing.IsAttending = isAttending;
        }
        else
        {
            match.MatchAttendances.Add(new MatchAttendance
            {
                MatchId = matchId,
                UserId = userId,
                IsAttending = isAttending
            });
        }

        await _context.SaveChangesAsync();
    }
}
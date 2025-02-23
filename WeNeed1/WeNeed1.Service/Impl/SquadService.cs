using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl
{
    public class SquadService : BaseCRUDService<SquadResponseDto, Squad, SquadSearchObject, SquadRequestDto, SquadRequestDto>, ISquadService
    {
        private readonly IUserService _userService;
        public SquadService(WeNeed1Context context, IMapper mapper, IUserService userService) : base(context, mapper)
        {
            _userService = userService;
        }

        public override async Task<SquadResponseDto> GetById(int id)
        {
            var entity = await _context.Squads
                .Include(s => s.Team)
                .Include(s => s.UserSquads)
                .ThenInclude(us => us.User)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (entity == null)
            {
                throw new Exception("Squad not found");
            }

            return _mapper.Map<SquadResponseDto>(entity);
        }

        public override IQueryable<Squad> AddFilter(IQueryable<Squad> query, SquadSearchObject? search = null)
        {
            if (search?.TeamId.HasValue == true)
            {
                query = query.Where(s => s.TeamId == search.TeamId.Value);
            }

            return query;
        }

        public async Task JoinSquad(int squadId)
        {
            var currentUser = await _userService.GetCurrentUserAsync();

            var userSquad = new UserSquad
            {
                UserId = currentUser.Id,
                SquadId = squadId
            };
            _context.UsersSquad.Add(userSquad);
            await _context.SaveChangesAsync();
        }

        public async Task LeaveSquad(int squadId)
        {
            var currentUser = await _userService.GetCurrentUserAsync();
            var userSquad = await _context.UsersSquad.FirstOrDefaultAsync(s => s.SquadId == squadId && s.UserId == currentUser.Id);

            if (userSquad == null)
                throw new Exception("User is not part of this squad");

            _context.UsersSquad.Remove(userSquad);
            await _context.SaveChangesAsync();
        }
    }

}

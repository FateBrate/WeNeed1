using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WeNeed1.Model.Exceptions;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service.Impl
{
    public class TeamService : BaseCRUDService<TeamResponseDto, Team, TeamSearchObject, TeamRequestDto, TeamRequestDto>, ITeamService
    {
        private readonly IUserService _userService;

        public TeamService(WeNeed1Context context, IMapper mapper, IUserService userService) : base(context, mapper)
        {
            _userService = userService;
        }

        public override IQueryable<Team> AddFilter(IQueryable<Team> query, TeamSearchObject search)
        {
            query = query.Include(t => t.UserTeams);

            if (search.Sport != null)
                query = query.Where(t => t.Sport == search.Sport);

            if (!string.IsNullOrEmpty(search.City))
                query = query.Where(t => t.City != null && 
                                         t.City.ToLower().Contains(search.City.ToLower()));

            if (!string.IsNullOrEmpty(search.Name))
                query = query.Where(t => t.Name != null && 
                                         t.Name.ToLower().Contains(search.Name.ToLower()));

            if (search.NotMember == true && search.UserId != null)
                query = query.Where(t => !t.UserTeams.Any(ut => ut.UserId == search.UserId));
            else if (search.UserId != null)
                query = query.Where(t => t.UserTeams.Any(ut => ut.UserId == search.UserId));
            
            if (search.IsPublic == true)
                query = query.Where(t => t.IsPublic == true);
            
            if (!string.IsNullOrWhiteSpace(search.JoinCode))
                query = query.Where(t => t.JoinCode != null &&
                                         t.JoinCode.ToLower() == search.JoinCode.ToLower());

            return query;
        }

        public override async Task<TeamResponseDto> GetById(int id)
        {
            var team = await _context.Teams
                .Include(t => t.UserTeams)
                .ThenInclude(ut => ut.User)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (team == null)
            {
                throw new UserException("Team not found.");
            }

            var dto = _mapper.Map<TeamResponseDto>(team);

            var user = await _userService.GetCurrentUserAsync();
            
            dto.IsMember = team.UserTeams.Any(ut => ut.UserId == user.Id);

            return dto;
        }

        public override async Task<TeamResponseDto> Insert(TeamRequestDto request)
        {
            var entity = _mapper.Map<Team>(request);

            var currentUser = await _userService.GetCurrentUserAsync();
            entity.CaptainId = currentUser.Id;

            entity.JoinCode = GenerateJoinCode();

            await _context.Teams.AddAsync(entity);
            await _context.SaveChangesAsync();
            var userTeam = new UserTeam
            {
                UserId = currentUser.Id,
                TeamId = entity.Id,
                IsCaptain = true
            };

            _context.UserTeams.Add(userTeam);

            await _context.SaveChangesAsync();
            return _mapper.Map<TeamResponseDto>(entity);
        }

        private string GenerateJoinCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public async Task JoinTeam(int teamId)
        {
            var currentUser = await _userService.GetCurrentUserAsync();

            var userTeam = new UserTeam
            {
                UserId = currentUser.Id,
                TeamId = teamId,
                IsCaptain = false
            };

            _context.UserTeams.Add(userTeam);
            await _context.SaveChangesAsync();
        }

        public async Task LeaveTeam(int teamId)
        {
            var currentUser = await _userService.GetCurrentUserAsync();

            var userTeam = await _context.UserTeams
                .FirstOrDefaultAsync(ut => ut.UserId == currentUser.Id && ut.TeamId == teamId);

            if (userTeam == null)
                throw new UserException("User is not part of this team.");


            if (userTeam.IsCaptain)
                throw new UserException("You cannot leave the team as you are the captain.");

            _context.UserTeams.Remove(userTeam);
            await _context.SaveChangesAsync();
        }
        public async Task AddToTeam(int teamId, int userId)
        {
            
            var team = await _context.Teams.FindAsync(teamId);
            if (team == null)
                throw new UserException("Team not found");
            
            var existingUserTeam = await _context.UserTeams
                .FirstOrDefaultAsync(ut => ut.UserId == userId && ut.TeamId == teamId);

            if (existingUserTeam != null)
                throw new UserException("User is already a member of the team.");
            
            var userTeam = new UserTeam
            {
                UserId = userId,
                TeamId = teamId,
                IsCaptain = false
            };
            _context.UserTeams.Add(userTeam);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveFromTeam(int teamId, int userId)
        {
            var currentUser = await _userService.GetCurrentUserAsync();


            var team = await _context.Teams.FindAsync(teamId);
            if (team == null || team.CaptainId != currentUser.Id)
                throw new UserException("Only the team captain can remove users from the team.");


            var userTeam = await _context.UserTeams
                .FirstOrDefaultAsync(ut => ut.UserId == userId && ut.TeamId == teamId);

            if (userTeam == null)
                throw new UserException("User is not a member of the team.");

            if (userTeam.IsCaptain)
                throw new UserException("Cannot remove the team captain from the team.");

            _context.UserTeams.Remove(userTeam);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TeamResponseDto>> GetTeamsForCurrentUserAsync()
        {
            var currentUser = await _userService.GetCurrentUserAsync();
            var userId = currentUser.Id;

            var teamsQuery = _context.Set<Team>().Where(t =>
                t.UserTeams.Any(ut => ut.UserId == userId));

            var teamsList = await teamsQuery.ToListAsync();
            var dtoList = _mapper.Map<List<TeamResponseDto>>(teamsList);

            return dtoList;
        }

    }

}

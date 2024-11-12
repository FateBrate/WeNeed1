using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Exceptions;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;
using User = WeNeed1.Model.User;

namespace WeNeed1.Service
{
    public class TeamService : BaseCRUDService<TeamResponseDto, Database.Team,TeamSearchObject ,TeamRequestDto, TeamRequestDto>, ITeamService
    {
        private readonly IUserService _userService;

        public TeamService(WeNeed1Context context, IMapper mapper, IUserService userService) : base(context, mapper)
        {
            _userService = userService;
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

            return _mapper.Map<TeamResponseDto>(team);
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
            var currentUser = await _userService.GetCurrentUserAsync();

            
            var team = await _context.Teams.FindAsync(teamId);
            if (team == null || team.CaptainId != currentUser.Id)
                throw new UserException("Only the team captain can add users to the team.");

            
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
        
    }
    
}

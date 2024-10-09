using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service.Database;

namespace WeNeed1.Service
{
    public class TeamService : BaseCRUDService<TeamResponseDto, Database.Team,TeamSearchObject ,TeamRequestDto, TeamRequestDto>, ITeamService
    {
        private readonly IUserService _userService;

        public TeamService(WeNeed1Context context, IMapper mapper, IUserService userService) : base(context, mapper)
        {
            _userService = userService;
        }

        public override async Task<TeamResponseDto> Insert(TeamRequestDto request)
        {
            var entity = _mapper.Map<Team>(request);

            var currentUser = await _userService.GetCurrentUserAsync();
            entity.CaptainId = currentUser.Id;

            entity.JoinCode = GenerateJoinCode();

            await _context.Teams.AddAsync(entity);
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
    }
}

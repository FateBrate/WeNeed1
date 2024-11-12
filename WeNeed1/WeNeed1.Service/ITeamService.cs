using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Service
{
    public interface ITeamService:ICRUDService<TeamResponseDto, TeamSearchObject, TeamRequestDto, TeamRequestDto>  
    {
        Task JoinTeam(int teamId);

        Task LeaveTeam(int teamId);
        Task AddToTeam(int teamId, int userId);
        Task RemoveFromTeam(int teamId, int userId);
    }
}

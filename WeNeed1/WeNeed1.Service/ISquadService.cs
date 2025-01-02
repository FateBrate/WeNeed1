using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;

namespace WeNeed1.Service
{
    public interface ISquadService:ICRUDService<SquadResponseDto,SquadSearchObject,SquadRequestDto,SquadRequestDto>
    {
        Task JoinSquad(int squadId);
        Task LeaveSquad(int squadId);
    }
}

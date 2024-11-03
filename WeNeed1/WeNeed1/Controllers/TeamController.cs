using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class TeamController : BaseCRUDController<TeamResponseDto,TeamSearchObject,TeamRequestDto,TeamRequestDto>
    {
        public TeamController(ILogger<BaseController<TeamResponseDto,TeamSearchObject>>logger ,ITeamService service)
            :base(logger, service)
        {

        }
    }
}

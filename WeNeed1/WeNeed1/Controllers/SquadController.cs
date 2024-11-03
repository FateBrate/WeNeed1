using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class SquadController : BaseCRUDController<SquadResponseDto,BaseSearchObject,SquadRequestDto,SquadRequestDto>
    {
        public SquadController(ILogger<BaseController<SquadResponseDto,BaseSearchObject>>logger, ISquadService service)
            :base(logger, service)
        { }
    }
}

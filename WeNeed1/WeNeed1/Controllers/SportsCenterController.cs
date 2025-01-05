using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class SportsCenterController : BaseCRUDController<SportsCenterResponseDto, BaseSearchObject,
        SportsCenterRequestDto, SportsCenterRequestDto>
    {
        public SportsCenterController(ILogger<BaseController<SportsCenterResponseDto, BaseSearchObject>> logger,
            ISportsCenterService service) : base(logger, service)
        {

        }
    }
}
using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class SportFieldController : BaseCRUDController<SportFieldResponseDto, SportFieldSearchObject,
        SportFieldRequestDto, SportFieldRequestDto>
    {
        public SportFieldController(ILogger<BaseController<SportFieldResponseDto, SportFieldSearchObject>> logger,
            ISportsFieldService service) : base(logger, service)
        {

        }
    }
}
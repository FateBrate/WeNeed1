using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    [Authorize]
    public class SportsCenterController : BaseCRUDController<SportsCenterResponseDto, SportCenterSearchObject,
        SportsCenterRequestDto, SportsCenterRequestDto>
    {
        private readonly ISportsCenterService _sportsCenterService;
        public SportsCenterController(ILogger<BaseController<SportsCenterResponseDto, SportCenterSearchObject>> logger,
            ISportsCenterService service) : base(logger, service)
        {
            _sportsCenterService = service;
        }
        
        [HttpGet("my")]
        [Authorize(Roles = "MANAGER")]
        public async Task<IActionResult> GetMySportsCenter()
        {
            var result = await _sportsCenterService.GetMySportsCenterAsync();
            return Ok(result);
        }
    }
}
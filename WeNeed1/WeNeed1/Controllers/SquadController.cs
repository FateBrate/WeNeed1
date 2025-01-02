using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class SquadController : BaseCRUDController<SquadResponseDto,SquadSearchObject,SquadRequestDto,SquadRequestDto>
    {
        private readonly ISquadService _service;

        public SquadController(ILogger<BaseController<SquadResponseDto, SquadSearchObject>> logger,
            ISquadService service)
            : base(logger, service)
        {
            _service = service;
        }
        
        [HttpPost("{squadId}/join")]
        public async Task<IActionResult> JoinSquad(int squadId)
        {
            await _service.JoinSquad(squadId);
            return Ok( new { message = "Successfully joined the squad." });
        }

        [HttpDelete("{squadId}/leave")]
        public async Task<IActionResult> LeaveSquad(int squadId)
        {
            await _service.LeaveSquad(squadId);
            return Ok(new { message = "Successfully left the squad." });
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    [Authorize]
    public class TeamController : BaseCRUDController<TeamResponseDto,TeamSearchObject,TeamRequestDto,TeamRequestDto>
    {
        private readonly ITeamService _service;
        public TeamController(ILogger<BaseController<TeamResponseDto,TeamSearchObject>>logger ,ITeamService service)
            :base(logger, service)
        {
            _service = service;
        }

        [HttpPost("{teamId}/join")]
        public async Task<IActionResult> JoinTeam(int teamId)
        {
            await _service.JoinTeam(teamId);
            return Ok(new { message = "Successfully joined the team." });
        }

        [HttpDelete("{teamId}/leave")]
        public async Task<IActionResult> LeaveTeam(int teamId)
        {
            await _service.LeaveTeam(teamId);
            return Ok(new { message = "Successfully left the team." });
        }
        
        [HttpPost("{teamId}/add")]
        public async Task<IActionResult> AddToTeam(int teamId, [FromQuery] int userId)
        {
            await _service.AddToTeam(teamId, userId);
            return Ok(new { message = "User added to the team successfully." });
        }

        [HttpDelete("{teamId}/remove")]
        public async Task<IActionResult> RemoveFromTeam(int teamId, [FromQuery] int userId)
        {
            await _service.RemoveFromTeam(teamId, userId);
            return Ok(new { message = "User removed from the team successfully." });
        }
    }
    
}

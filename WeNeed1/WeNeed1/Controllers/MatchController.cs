using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchObjects;
using WeNeed1.Service;
using WeNeed1.Service.Database;

namespace WeNeed1.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class MatchController : BaseCRUDController<MatchResponseDto, MatchSearchObject, MatchRequestDto, MatchRequestDto>
    {
        private readonly IMatchService _matchService;
        private readonly IUserService _userService;

        public MatchController(
            ILogger<BaseController<MatchResponseDto, MatchSearchObject>> logger,
            IMatchService matchService,
            IUserService userService)
            : base(logger, matchService)
        {
            _matchService = matchService;
            _userService = userService;
        }

        [HttpPatch("{matchId}/attendance")]
        public async Task<IActionResult> SetAttendance(int matchId, [FromBody] bool isAttending)
        {
            var user = await _userService.GetCurrentUserAsync();


            await _matchService.SetAttendance(matchId, user.Id, isAttending);

            return Ok(new { message = "Attendance updated." });
        }
    }
}

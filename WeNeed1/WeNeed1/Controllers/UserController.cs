using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Payloads;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class UserController : BaseCRUDController<Model.User,Model.SearchOBjects.UserSearchObject,UserRequestDto,UserUpdateDto>
    {
        private readonly IUserService _userService;
        public UserController(ILogger<BaseController<Model.User, Model.SearchOBjects.UserSearchObject>> logger, IUserService service)
           : base(logger, service)
        {
            _userService = service;
        }
        
        
        [HttpGet("profile")]
        [Authorize]
        public async Task<IActionResult> GetProfile()
        {
            var profile = await _userService.GetCurrentUserAsync();
            return Ok(profile);
        }
    }
}

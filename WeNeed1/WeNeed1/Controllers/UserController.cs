using Microsoft.AspNetCore.Mvc;
using WeNeed1.Model.Requests;
using WeNeed1.Service;

namespace WeNeed1.Controllers
{
    [ApiController]
    public class UserController : BaseCRUDController<Model.User,Model.SearchOBjects.UserSearchObject,UserRequestDto,UserUpdateDto>
    {
        public UserController(ILogger<BaseController<Model.User, Model.SearchOBjects.UserSearchObject>> logger, IUserService service)
           : base(logger, service)
        {
        }

    }
}

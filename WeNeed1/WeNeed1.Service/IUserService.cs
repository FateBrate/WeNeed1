using WeNeed1.Model.Enums;
using WeNeed1.Model.Payloads;
using WeNeed1.Model.SearchOBjects;

namespace WeNeed1.Service
{
    public interface IUserService : ICRUDService<Model.User, UserSearchObject, UserRequestDto, UserUpdateDto>
    {
        Task<Model.User> Login(string username, string password);
        Task<Model.User> GetCurrentUserAsync();
        
        Task ChangePasswordAsync(UserChangePasswordRequest userChangePass);

        Task UpdateUserSportsAsync(int userId, List<Sport> sports);
    }
}

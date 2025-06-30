using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using WeNeed1.Model.SearchOBjects;
using WeNeed1.Model.Exceptions;
using WeNeed1.Service.Database;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using WeNeed1.Model.Enums;
using WeNeed1.Model.Payloads;

namespace WeNeed1.Service.Impl
{
    public class UserService : BaseCRUDService<Model.User, User, UserSearchObject, UserRequestDto, UserUpdateDto>, IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserService(WeNeed1Context context, IMapper mapper, IHttpContextAccessor httpContextAccessor)
            : base(context, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public override async Task BeforeInsert(User entity, UserRequestDto insert)
        {
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, insert.Password);
            
            if (insert.Role == Role.MANAGER)
            {
                var sportsCenter = new SportsCenter
                {
                    Name = $"{insert.FirstName}'s Sports Center",
                    Address = "Enter your address",
                    Description = "Managed by " + insert.FirstName,
                    Manager = entity
                };

                _context.SportsCenters.Add(sportsCenter);
            }
        }

        public override IQueryable<User> AddFilter(IQueryable<User> query, UserSearchObject? search = null)
        {
            if (!string.IsNullOrEmpty(search?.FirstName))
            {
                query = query.Where(x => x.FirstName.StartsWith(search.FirstName));
            }

            return base.AddFilter(query, search);
        }

        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);

            return Convert.ToBase64String(byteArray);
        }

        public static string GenerateHash(string salt, string password)
        {
            var saltBytes = Convert.FromBase64String(salt);
            using var hmac = new HMACSHA256(saltBytes);
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            var hashBytes = hmac.ComputeHash(passwordBytes);
            return Convert.ToBase64String(hashBytes);
        }

        public async Task<Model.User> Login(string username, string password)
        {
            var entity = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            if (entity == null)
                throw new UserException("Invalid username or password.");

            var hash = GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
                throw new UserException("Invalid username or password.");

            return _mapper.Map<Model.User>(entity);
        }

        public async Task<Model.User> GetCurrentUserAsync()
        {
            var userIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userIdClaim == null)
                throw new UserException("User is not authenticated");

            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userIdClaim);

            if (user == null)
                throw new UserException("User not found");

            return _mapper.Map<Model.User>(user);
        }

        public async Task ChangePasswordAsync(UserChangePasswordRequest userChangePass)
        {
            var user = await _context.Users.FindAsync(userChangePass.Id);

            if (user == null)
                throw new UserException($"User with ID {userChangePass.Id} not found.");

            var currentHash = GenerateHash(user.PasswordSalt, userChangePass.Password);
            
            if (user.PasswordHash != currentHash)
                throw new ApiException("INVALID_PASSWORD", 470);

            user.PasswordSalt = GenerateSalt();
            user.PasswordHash = GenerateHash(user.PasswordSalt, userChangePass.NewPassword);

            _context.Update(user);
            await _context.SaveChangesAsync();
        }
        
        public override async  Task<Model.User> Update(int id, UserUpdateDto update)
        {
               var user = await _context.Users.FindAsync(id);;
                if (user != null)
                {
                    user.FirstName = update.FirstName;
                    user.LastName = update.LastName;
                    user.Email = update.Email;
                    user.PhoneNumber = update.PhoneNumber;
                    user.ProfilePicture = update.ProfilePicture;
                    await _context.SaveChangesAsync();
                }
                return _mapper.Map<Model.User>(user);
        }

        public async Task UpdateUserSportsAsync(int userId, List<Sport> sports)
        {
            var user = await _context.Users.Include(u => u.UserSports).FirstOrDefaultAsync(u => u.Id == userId);
            if (user == null)
                throw new Exception("User not found");

            _context.UserSports.RemoveRange(user.UserSports);

            foreach (var sport in sports.Distinct())
            {
                user.UserSports.Add(new UserSport
                {
                    UserId = userId,
                    Sport = sport
                });
            }

            await _context.SaveChangesAsync();
        }

    }
    
}

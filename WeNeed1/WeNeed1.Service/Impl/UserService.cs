using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WeNeed1.Model.Requests;
using WeNeed1.Model.SearchOBjects;
using WeNeed1.Model.Exceptions;
using WeNeed1.Service.Database;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;

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
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
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
    }
}

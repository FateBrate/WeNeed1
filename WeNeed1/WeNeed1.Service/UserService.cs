﻿using AutoMapper;
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

namespace WeNeed1.Service
{
    public class UserService : BaseCRUDService<Model.User, Database.User, UserSearchObject, UserRequestDto, UserUpdateDto>, IUserService
    {
        public UserService(WeNeed1Context context, IMapper mapper)
            : base(context, mapper)
        {

        }

        public override Task<Model.User> Insert(UserRequestDto insert)
        {
            return base.Insert(insert);
        }

        public override Task<Model.User> Delete(int id)
        {
            return base.Delete(id);
        }

        public override async Task BeforeInsert(Database.User entity, UserRequestDto insert)
        {
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, insert.Password);
        }

        public override IQueryable<Database.User> AddFilter(IQueryable<Database.User> query, UserSearchObject? search = null)
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

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

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

        public override async Task<Model.User> Update(int id, UserUpdateDto update)
        {
            var entity = await _context.Users.FindAsync(id);
            return await base.Update(id, update);
        }
    }
}
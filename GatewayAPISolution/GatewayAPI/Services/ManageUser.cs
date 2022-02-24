using GatewayAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GatewayAPI.Services
{
    public class ManageUser : IManageUser<UserDTO>
    {
        private readonly UserDbContext _context;
        private readonly IGenerateToken<UserDTO> _token;

        public ManageUser(UserDbContext context, IGenerateToken<UserDTO> token)
        {
            _context = context;
            _token = token;
        }

        public async Task<UserDTO> Add(UserDTO user)
        {
            using var hmac = new HMACSHA512();
            var user1 = new User()
            {
                Username = user.Username,
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password)),
                PassHash = hmac.Key,
                UserType = user.UserType
            };
            _context.Users.Add(user1);
            await _context.SaveChangesAsync();
            user.Password = "";
            return new UserDTO() { Username = user.Username, Token = _token.CreateToken(user), UserType = user.UserType };
        }

        public async Task<UserDTO> Login(UserDTO user)
        {
            var myUser = _context.Users.SingleOrDefault(u => u.Username == user.Username);
            if (myUser == null)
                return null;
            using var hmac = new HMACSHA512(myUser.PassHash);
            var userPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            for (int i = 0; i < userPass.Length; i++)
            {
                if (userPass[i] != myUser.Password[i])
                    return null;
            }
            user.Password = "";
            return new UserDTO() { Username = user.Username, Token = _token.CreateToken(user), UserType = user.UserType };
        }
    }
}

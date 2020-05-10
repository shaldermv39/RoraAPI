using RoraAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoraAPI.BL
{
    public class AuthRepository : IAuthInterface
    {
        public Task<User> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<User> Register(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}

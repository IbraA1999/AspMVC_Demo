using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspMVC_Demo.BLL.Interfaces;
using AspMVC_Demo.DAL.InterfaceRepositories;
using AspMVC_Demo.Domain.Entities;

namespace AspMVC_Demo.BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepositorie _IAuthRepositorie;

        public AuthService(IAuthRepositorie iAuthRepositorie)
        {
            _IAuthRepositorie = iAuthRepositorie;
        }

        public User? Login(User contact)
        {
            throw new NotImplementedException();
        }

        public User? Register(User contact)
        {
            return _IAuthRepositorie.Register(contact);
        }
    }
}

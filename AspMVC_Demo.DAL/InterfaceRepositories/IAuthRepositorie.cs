using AspMVC_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVC_Demo.DAL.InterfaceRepositories
{
    public interface IAuthRepositorie
    {
        public User? Register(User user);
        public User? Login(User user);
    }
}

using AspMVC_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVC_Demo.BLL.Interfaces
{
    public interface IAuthService
    {
        public User? Register(User contact);

        public User? Login(User contact);
    }
}

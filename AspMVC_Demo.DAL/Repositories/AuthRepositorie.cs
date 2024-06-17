using AspMVC_Demo.DAL.InterfaceRepositories;
using AspMVC_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsBox;

namespace AspMVC_Demo.DAL.Repositories
{
    public class AuthRepositorie : IAuthRepositorie
    {
        private readonly DbConnection _connectionString;

        public AuthRepositorie(DbConnection connectionString)
        {
            _connectionString = connectionString;
        }

        public User? Login(User user)
        {
            throw new NotImplementedException();
        }

        public User? Register(User user)
        {
            _connectionString.Open();
            int rowsAffected = _connectionString.ExecuteNonQuery("CreateUser", true, user);

            return rowsAffected > 0 ? user : null;
        }
    }
}

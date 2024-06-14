using AspMVC_Demo.DAL.InterfaceRepositories;
using AspMVC_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVC_Demo.DAL.Repositories
{
    public class ContactRepositorie : IContactRepositories
    {

        private readonly DbConnection? _connectionString;

        public ContactRepositorie(DbConnection? connectionString)
        {
            _connectionString = connectionString;
        }

        public Contact? Create(Contact Contact)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public Contact? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Contact? Update(Contact Contact)
        {
            throw new NotImplementedException();
        }
    }
}

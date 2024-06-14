using AspMVC_Demo.DAL.InterfaceRepositories;
using AspMVC_Demo.DAL.MapperData;
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
    public class ContactRepositorie : IContactRepositories
    {

        private readonly DbConnection? _connectionString;

        public ContactRepositorie(DbConnection? connectionString)
        {
            _connectionString = connectionString;
        }

        public Contact? Create(Contact contact)
        {
            _connectionString?.Open();
            _connectionString?.ExecuteNonQuery("CreateContact", true, new { contact.Nom, contact.Prenom, contact.Email });

            return contact;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll()
        {

            _connectionString?.Open();
            IEnumerable<Contact> contacts = _connectionString.ExecuteReader("SELECT * FROM Contact", contact => contact.ToContact());

            return contacts;
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

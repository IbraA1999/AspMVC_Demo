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
            _connectionString.Open();
            int rowsAffected = _connectionString.ExecuteNonQuery("DELETE FROM Contact WHERE id = @id", false, new { id });

            return rowsAffected > 0 ? true : false;
        }

        public IEnumerable<Contact> GetAll()
        {

            _connectionString?.Open();
            IEnumerable<Contact> contacts = _connectionString.ExecuteReader("SELECT * FROM Contact", contact => contact.ToContact());

            return contacts;
        }

        public Contact? GetById(int id)
        {
            _connectionString.Open();
            Contact? contact = _connectionString.ExecuteReader("SELECT * FROM Contact WHERE Id = @Id", db => db.ToContact(), false, new { id }).SingleOrDefault();
            _connectionString.Close();

            return contact;
        }

        public Contact? Update(Contact contact)
        {
            _connectionString.Open();
           int rowsAffected =  _connectionString.ExecuteNonQuery("UPDATE Contact SET Nom = @Nom, Prenom = @Prenom, Email = @Email WHERE Id = @Id", false, new { contact.Nom, contact.Prenom, contact.Email, contact.Id });

            return rowsAffected > 0 ? contact : null;
        }
    }
}

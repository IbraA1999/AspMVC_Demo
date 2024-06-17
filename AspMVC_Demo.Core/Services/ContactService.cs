using AspMVC_Demo.BLL.InterfaceService;
using AspMVC_Demo.DAL.InterfaceRepositories;
using AspMVC_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVC_Demo.BLL.Service
{
    public class ContactService : IContactService
    {

        private readonly IContactRepositories _contactRepositorie;

        public ContactService(IContactRepositories contactRepositorie)
        {
            _contactRepositorie = contactRepositorie;
        }

        public Contact? Create(Contact Contact)
        {
            return _contactRepositorie.Create(Contact);
        }

        public bool Delete(int id)
        {
            return _contactRepositorie.Delete(id);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _contactRepositorie.GetAll();    
        }

        public Contact? GetById(int id)
        {
            Contact? contact = _contactRepositorie.GetById(id);

            if (contact is not null)
            {
                return contact; 
            } 

            return null;
        }

        public Contact? Update(Contact Contact)
        {
            return _contactRepositorie.Update(Contact);
        }
    }
}

using AspMVC_Demo.BLL.InterfaceService;
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

        private readonly IContactService _contactService;

        public ContactService(IContactService contactService)
        {
            _contactService = contactService;
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

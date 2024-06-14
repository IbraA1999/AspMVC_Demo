using AspMVC_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVC_Demo.BLL.InterfaceService
{
    public interface IContactService
    {
        public Contact? Create(Contact Contact);
        public Contact? Update(Contact Contact);
        public bool Delete(int id);
        public Contact? GetById(int id);
        public IEnumerable<Contact> GetAll();
    }
}

using AspMVC_Demo.Domain.Entities;
using AspMVC_Demo.Web.Models;

namespace AspMVC_Demo.Web.Mapper
{
    public static class ContactMapper
    {
        public static Contact ToContact(this CreateContactForm contactForm)
        {
            return new Contact
            {
                Nom = contactForm.Nom,
                Prenom = contactForm.Prenom,
                Email = contactForm.Email
            };
        }
    }
}

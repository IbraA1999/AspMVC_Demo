using AspMVC_Demo.BLL.InterfaceService;
using AspMVC_Demo.Domain.Entities;
using AspMVC_Demo.Web.Mapper;
using AspMVC_Demo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace AspMVC_Demo.Web.Controllers
{
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult GererContact()
        {
            return View();
        }

        public IActionResult AfficherContact() 
        {
            IEnumerable<Contact> contacts = _contactService.GetAll();

            if (contacts.Count() > 0)
            {
                return View(contacts);
            }

            return RedirectToAction("GererContact");
        }

        [HttpGet]
        public IActionResult EnregistrerContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EnregistrerContact(CreateContactForm contactForm)
        {
            Contact contact = contactForm.ToContact();
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                Contact? createContact = _contactService.Create(contact);

                if (createContact is null)
                {
                    return View();
                }

                return RedirectToAction("AfficherContact");
            }
        }

        public IActionResult DeleteContact(int id)
        {
            bool IsDelete = _contactService.Delete(id);

            if (IsDelete)
            {
                return RedirectToAction("AfficherContact");
            }

            return View("GererContact");
        }


        public IActionResult ModifierContact(int id, CreateContactForm contactForm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {

                Contact contact = contactForm.ToContact();
                contact.Id = id;
                Contact? UpdateIsValid = _contactService.Update(contact);

                if (UpdateIsValid is not null)
                {
                    return RedirectToAction("AfficherContact");
                } else
                {
                    return View();
                }
            }
        }

        public IActionResult DetailContact(int id)
        {
            Contact? contact = _contactService.GetById(id);

            if (contact is not null)
            {
                return View(contact);
            }

            return RedirectToAction("AfficherContact");
        }




    }
}

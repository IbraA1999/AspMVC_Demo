using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVC_Demo.Domain.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public required string Nom { get; set; }

        public required string Prenom { get; set; }

        public string Email { get; set; }
    }
}

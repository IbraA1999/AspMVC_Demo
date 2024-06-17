using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspMVC_Demo.Domain.Entities
{
    public class User
    {
        [NotMapped]
        public int Id { get; set; }

        public string Pseudo { get; set; }

        public string Email {  get; set; }

        public string Password { get; set; }
    }
}

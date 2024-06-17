using System.ComponentModel.DataAnnotations;

namespace AspMVC_Demo.Web.Models
{
    public class LoginUser
    {
        [Required]
        [MinLength(1)]
        public string Email { get; set; }

        [Required]
        [MinLength(1)]
        public string Password { get; set; }
    }
}

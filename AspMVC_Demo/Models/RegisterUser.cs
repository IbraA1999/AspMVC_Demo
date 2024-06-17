using System.ComponentModel.DataAnnotations;

namespace AspMVC_Demo.Web.Models
{
    public class RegisterUser
    {
        [Required]
        public required string Pseudo { get; set; }
        [Required]
        [EmailAddress]
        public required string Email{ get; set; }
        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,25}$"
        , ErrorMessage = "Le mot de passe doit contenir 1 Maj, 1 Min, 1 chiffre, 1 char spécial")]
        public required string Password{ get; set; }
        [Required]
        [Compare("Password")]
        public required string PasswordCheck { get; set; }
    }
}

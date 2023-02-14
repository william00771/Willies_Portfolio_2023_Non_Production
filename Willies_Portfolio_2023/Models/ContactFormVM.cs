using System.ComponentModel.DataAnnotations;

namespace Willies_Portfolio_2023.Models
{
    public class ContactFormVM
    {
        [Required(ErrorMessage = "Full Name missing")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email Adress missing")]
        
        public string Email { get; set; }

        [Required(ErrorMessage = "Message missing")]
        public string Message { get; set; }
    }
}

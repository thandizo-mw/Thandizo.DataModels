using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.Identity.DataTransfer
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Phone number cannot be blank")]
        [MinLength(10, ErrorMessage = "Minimum number of characters for phone number is 10")]
        [Display(Name = "Phone number")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.Identity.DataTransfer
{
    public class UserDTO
    {
        [Required(ErrorMessage = "Phone number cannot be blank")]
        [MinLength(10, ErrorMessage = "Minimum number of characters for phone number is 10")]
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}

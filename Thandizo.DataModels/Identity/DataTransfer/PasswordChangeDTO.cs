using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.Identity.DataTransfer
{
    public class PasswordChangeDTO
    {
        [Required(ErrorMessage = "Phone number cannot be blank")]
        [MinLength(10, ErrorMessage = "Minimum number of characters for phone number is 10")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Current password cannot be blank")]
        [MinLength(6, ErrorMessage = "Minimum number of characters for the current password is 6")]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Current password cannot be blank")]
        [MinLength(6, ErrorMessage = "Minimum number of characters for the new password is 6")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "New password confirmation field cannot be blank")]
        [MinLength(6, ErrorMessage = "Minimum number of characters for the new password is 6")]
        public string NewPasswordConfirmation { get; internal set; }
        public string ReturnUrl { get; set; }
    }
}

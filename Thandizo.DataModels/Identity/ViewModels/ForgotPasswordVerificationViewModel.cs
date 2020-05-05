using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.Identity.ViewModels
{
    public class ForgotPasswordVerificationViewModel
    {

        [Required(ErrorMessage ="Verification Code is required to complete the password reset process")]
        public string Code { get; set; }
        [Display(Name = "Phone number")]
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
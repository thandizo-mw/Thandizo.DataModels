using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.Identity.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [DisplayName("Phone Number")]
        [Required]
        public string PhoneNumber { get; set; }
    }
}
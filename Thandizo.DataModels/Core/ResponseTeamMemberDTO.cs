using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public class ResponseTeamMemberDTO : BaseRowDTO
    {
        public int TeamMemberId { get; set; }

        [Required(ErrorMessage = "First Name cannot be blank")]
        [MaxLength(30, ErrorMessage = "Maximum number of characters for First Name is 30")]
        public string FirstName { get; set; }

        public string OtherNames { get; set; }

        [Required(ErrorMessage = "Surname cannot be blank")]
        [MaxLength(30, ErrorMessage = "Maximum number of characters for Surname is 30")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Phone Number cannot be blank")]
        [MaxLength(15, ErrorMessage = "Maximum number of characters for Phone Number is 15")]
        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }
    }
}

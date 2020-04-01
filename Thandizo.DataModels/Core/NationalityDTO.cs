using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public class NationalityDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "Nationality Code cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for Nationality Code is 2")]
        [MaxLength(5, ErrorMessage = "Maximum number of characters for Nationality Code is 5")]
        public string NationalityCode { get; set; }

        [Required(ErrorMessage = "Nationality Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Nationality Name is 40")]
        public string NationalityName { get; set; }
    }
}

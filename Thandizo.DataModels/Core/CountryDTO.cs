using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public class CountryDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "Country Code cannot be blank")]
        [MinLength(2, ErrorMessage ="Minimum number of characters for Country Code is 2")]
        [MaxLength(3, ErrorMessage = "Maximum number of characters for Country Code is 3")]
        public string CountryCode { get; set; }


        [Required(ErrorMessage = "Country Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Country Name is 40")]
        public string CountryName { get; set; }
    }
}

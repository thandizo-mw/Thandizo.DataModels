using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientTravelHistoryDTO : DataCreatorDTO
    {
        [Required(ErrorMessage = "Travel Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid Number for Travel Id")]
        public long TravelId { get; set; }

        [Required(ErrorMessage = "Country Code cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for Country Code is 2")]
        [MaxLength(3, ErrorMessage = "Maximum number of characters for Country Code is 3")]
        public string CountryCode { get; set; }

        [Required(ErrorMessage = "Patient Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid Number for Patient Id")]
        public long PatientId { get; set; }
    }
}

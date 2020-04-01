using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientStatusDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "Patient Status Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Patient Status Id")]
        public int PatientStatusId { get; set; }

        [Required(ErrorMessage = "Patient Status Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum length for Patient Status Name is 40")]
        public string PatientStatusName { get; set; }

        [Required(ErrorMessage = "Severity cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Severity")]
        public int Severity { get; set; }
    }
}

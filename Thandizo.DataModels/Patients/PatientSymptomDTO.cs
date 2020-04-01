using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientSymptomDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "Symptom Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Symptom Id")]
        public int SymptomId { get; set; }

        [Required(ErrorMessage = "Symptom Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum length for Symptom Name is 40")]
        public string SymptomName { get; set; }
    }
}

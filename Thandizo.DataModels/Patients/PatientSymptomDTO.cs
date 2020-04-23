using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientSymptomDTO : BaseRowDTO
    {
        public int SymptomId { get; set; }

        [Required(ErrorMessage = "Symptom Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum length for Symptom Name is 40")]
        public string SymptomName { get; set; }

        public string ExternalReferenceNumber { get; set; }

        [Required(ErrorMessage = "Is Available For Registration cannot be blank")]
        public bool IsAvailableForRegistration { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientDailyStatusDTO : DataCreatorDTO
    {
        [Required(ErrorMessage = "Submission Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid number for Submission Id")]
        public long SubmissionId { get; set; }

        [Required(ErrorMessage = "Symptom Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Symptom Id")]
        public int SymptomId { get; set; }

        [Required(ErrorMessage = "Patient Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid number for Patient Id")]
        public long PatientId { get; set; }

        [Required(ErrorMessage = "Date Submitted cannot be blank")]
        public DateTime DateSubmitted { get; set; }
    }
}

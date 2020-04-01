using System;
using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientHistoryDTO : DataCreatorDTO
    {
        [Required(ErrorMessage = "History Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid number for history Id")]
        public long HistoryId { get; set; }

        [Required(ErrorMessage = "Patient Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid number for Patient Id")]
        public long PatientId { get; set; }

        [Required(ErrorMessage = "Patient Status Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Patient Status Id")]
        public int PatientStatusId { get; set; }

        [Required(ErrorMessage = "Date Reported cannot be blank")]
        public DateTime DateReported { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientLocationMovementDTO : DataCreatorDTO
    {
        public long MovementId { get; set; }

        [Required(ErrorMessage = "Patient Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid Number for Patient Id")]
        public long PatientId { get; set; }

        [Required(ErrorMessage = "District Code cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid Number for Distrcit Code")]
        public string DistrictCode { get; set; }

        [MaxLength(100, ErrorMessage = "Maximum length for Image Path is 100")]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Movement Date cannot be blank")]
        public DateTime MovementDate { get; set; }
    }
}

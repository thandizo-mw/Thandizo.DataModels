using System;
using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientFacilityMovementDTO : DataCreatorDTO
    {
        [Required(ErrorMessage = "Movement Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid number for Movement Id")]
        public long MovementId { get; set; }

        [Required(ErrorMessage = "Patient Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid number for Patient Id")]
        public long PatientId { get; set; }

        [Required(ErrorMessage = "From Data Center Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for From Data Denter Id")]
        public int FromDataCenterId { get; set; }

        [Required(ErrorMessage = "To Data Center Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for To Data Denter Id")]
        public int ToDataCenterId { get; set; }

        [Required(ErrorMessage = "Movement Date cannot be blank")]
        public DateTime MovementDate { get; set; }
    }
}

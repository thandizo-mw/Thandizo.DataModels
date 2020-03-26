using System;

namespace Thandizo.DataModels.Patients
{
    public class PatientLocationMovementDTO
    {
        public long MovementId { get; set; }
        public long PatientId { get; set; }
        public string DistrictCode { get; set; }
        public string ImagePath { get; set; }
        public DateTime MovementDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}

using System;

namespace Thandizo.DataModels.Patients
{
    public class PatientFacilityMovementDTO
    {
        public long MovementId { get; set; }
        public long PatientId { get; set; }
        public int FromDataCenterId { get; set; }
        public int ToDataCenterId { get; set; }
        public DateTime MovementDate { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}

using System;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientFacilityMovementDTO : DataCreatorDTO
    {
        public long MovementId { get; set; }
        public long PatientId { get; set; }
        public int FromDataCenterId { get; set; }
        public int ToDataCenterId { get; set; }
        public DateTime MovementDate { get; set; }
    }
}

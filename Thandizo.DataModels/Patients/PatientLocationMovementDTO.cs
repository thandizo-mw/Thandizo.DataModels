using System;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientLocationMovementDTO : DataCreatorDTO
    {
        public long MovementId { get; set; }
        public long PatientId { get; set; }
        public string DistrictCode { get; set; }
        public string ImagePath { get; set; }
        public DateTime MovementDate { get; set; }
    }
}

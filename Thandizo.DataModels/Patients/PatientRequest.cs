using System.Collections.Generic;

namespace Thandizo.DataModels.Patients
{
    public class PatientRequest
    {
        public PatientDTO Patient { get; set; }
        public IEnumerable<PatientDailyStatusDTO> PatientDailyStatuses { get; set; }
    }
}

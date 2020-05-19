using System.Collections.Generic;
using Thandizo.DataModels.Patients;

namespace Thandizo.DataModels.Contracts
{
    public class DhisPatientDailyStatusRequest : IDhisPatientDailyStatusRequest
    {
        public DhisPatientDailyStatusRequest(IEnumerable<PatientDailyStatusDTO> statuses)
        {
            Statuses = statuses;
        }

        public IEnumerable<PatientDailyStatusDTO> Statuses { get; }
    }
}

using System.Collections.Generic;
using Thandizo.DataModels.Patients;

namespace Thandizo.DataModels.Contracts
{
    public interface IDhisPatientDailyStatusRequest
    {
        IEnumerable<PatientDailyStatusDTO> Statuses { get; }
    }
}
using System;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientDailyStatusDTO : DataCreatorDTO
    {
        public int SubmissionId { get; set; }
        public int SymptomId { get; set; }
        public long PatientId { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}

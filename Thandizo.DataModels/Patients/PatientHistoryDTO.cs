using System;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientHistoryDTO : DataCreatorDTO
    {
        public long HistoryId { get; set; }
        public long PatientId { get; set; }
        public int PatientStatusId { get; set; }
        public DateTime DateReported { get; set; }
    }
}

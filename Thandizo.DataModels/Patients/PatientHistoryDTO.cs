using System;

namespace Thandizo.DataModels.Patients
{
    public class PatientHistoryDTO
    {
        public long HistoryId { get; set; }
        public long PatientId { get; set; }
        public int PatientStatusId { get; set; }
        public DateTime DateReported { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}

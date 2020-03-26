using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientStatusDTO : BaseRowDTO
    {
        public int PatientStatusId { get; set; }
        public string PatientStatusName { get; set; }
        public int Severity { get; set; }
    }
}

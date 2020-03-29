using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientSymptomDTO : BaseRowDTO
    {
        public int SymptomId { get; set; }
        public string SymptomName { get; set; }
    }
}

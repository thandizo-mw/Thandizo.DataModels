using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class TransmissionClassificationDTO : BaseRowDTO
    {
        public int ClassificationId { get; set; }
        public string ClassificationName { get; set; }
    }
}

using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Resources
{
    public class ResourceAllocationDTO : BaseRowDTO
    {
        public long ResourceAllocationId { get; set; }
        public int PatientStatusId { get; set; }
        public int ResourceId { get; set; }
        public int RequiredQuantity { get; set; }
    }
}

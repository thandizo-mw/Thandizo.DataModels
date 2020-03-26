using Thandizo.DataModels.General;

namespace Thandizo.DataModels.DataCenters
{
    public class HealthFacilityResourceDTO : BaseRowDTO
    {
        public int FacilityResourceId { get; set; }
        public int CenterId { get; set; }
        public long ResourceAllocationId { get; set; }
        public int Quantity { get; set; }
    }
}

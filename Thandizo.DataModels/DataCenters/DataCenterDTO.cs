using Thandizo.DataModels.General;

namespace Thandizo.DataModels.DataCenters
{
    public class DataCenterDTO : BaseRowDTO
    {
        public int CenterId { get; set; }
        public string CenterName { get; set; }
        public int FacilityTypeId { get; set; }
        public string DistrictCode { get; set; }
        public bool IsHealthFacility { get; set; }
    }
}

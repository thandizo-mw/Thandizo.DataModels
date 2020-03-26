using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public  class DistrictDTO : BaseRowDTO
    {
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public int RegionId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}

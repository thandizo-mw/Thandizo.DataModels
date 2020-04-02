namespace Thandizo.DataModels.Statistics
{
    public class RegionalStatisticsDTO : NationalStatisticsDTO
    {
        public string RegionName { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}

namespace Thandizo.DataModels.Statistics
{
    public class RegionalStatisticsDTO : NationalStatisticsDTO
    {
        public string RegionName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

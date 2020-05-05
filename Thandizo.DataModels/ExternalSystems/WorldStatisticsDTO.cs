namespace Thandizo.DataModels.ExternalSystems
{
    public class WorldStatisticsDTO
    {
        public int TotalConfirmed { get; set; }
        public int TotalRecovered { get; set; }
        public int TotalDeaths { get; set; }
        public int NewConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int NewRecovered { get; set; }
    }
}

namespace Thandizo.DataModels.ExternalSystems
{
    public class DhisNationalStatisticsDTO
    {
        public int NumberOfSuspectedCases { get; set; }
        public int NumberOfConfirmedCases { get; set; }
        public int NumberOfConfirmedDeaths { get; set; }
        public int NumberOfRecoveredPatients { get; set; }
        public int NumberOfActiveCases
        {
            get
            {
                return NumberOfConfirmedCases - (NumberOfConfirmedDeaths + NumberOfRecoveredPatients);
            }
        }
        public int NumberOfReceivedSamples { get; set; }
        public int NumberOfTestedSamples { get; set; }
    }
}

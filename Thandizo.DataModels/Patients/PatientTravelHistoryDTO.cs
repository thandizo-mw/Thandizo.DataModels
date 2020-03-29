using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientTravelHistoryDTO : DataCreatorDTO
    {
        public int TravelId { get; set; }
        public string CountryCode { get; set; }
        public long PatientId { get; set; }
    }
}

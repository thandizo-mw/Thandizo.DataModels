namespace Thandizo.DataModels.Patients.Responses
{
    public class PatientFacilityResponse : PatientFacilityMovementDTO
    {
        public string FromDataCenterName { get; set; }
        public string ToDataCenterName { get; set; }
    }
}

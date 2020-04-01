namespace Thandizo.DataModels.Patients.Responses
{
    public class PatientFacilityMovementResponse : PatientFacilityMovementDTO
    {
        public string FromDataCenterName { get; set; }
        public string ToDataCenterName { get; set; }
    }
}

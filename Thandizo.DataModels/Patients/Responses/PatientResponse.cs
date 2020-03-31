namespace Thandizo.DataModels.Patients.Responses
{
    public class PatientResponse : PatientDTO
    {
        public string PatientStatusName { get; set; }
        public string DistrictName { get; set; }
        public string IdentitificationTypeName { get; set; }
        public string NationalityName { get; set; }
        public string ClassificationName { get; set; }
    }
}

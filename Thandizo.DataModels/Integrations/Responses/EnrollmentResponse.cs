namespace Thandizo.DataModels.Integrations.Responses
{
    public class EnrollmentResponse : ImportCountResponse
    {
        public string ResponseType { get; set; }
        public string Status { get; set; }        
        public int Total { get; set; }
    }
}

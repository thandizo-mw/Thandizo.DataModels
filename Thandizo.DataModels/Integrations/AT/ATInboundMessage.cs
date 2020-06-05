namespace Thandizo.DataModels.Integrations.AT
{
    public class ATInboundMessage
    {
        public string SessionId { get; set; }
        public string PhoneNumber { get; set; }
        public string Text { get; set; }
        public string ServiceCode { get; set; }
    }
}

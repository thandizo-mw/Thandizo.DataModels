namespace Thandizo.DataModels.SMS
{
    public class SmsMessage
    {
        public string Message { get; set; }
        public string[] Recipients { get; set; }
        public string Source { get; set; }
        public string Sender { get; set; }
        public string TransactionReference { get; set; }
    }
}

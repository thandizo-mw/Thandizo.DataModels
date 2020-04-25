using System.Runtime.Serialization;

namespace Thandizo.DataModels.Ussd
{
    public class UssdInboundDTO
    {
        public string Msisdn { get; set; }
        public string Body { get; set; }
        public string Sessionid { get; set; }
        public string Type { get; set; }
    }
}

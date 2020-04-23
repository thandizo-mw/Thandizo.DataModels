using System.Runtime.Serialization;

namespace Thandizo.DataModels.Ussd
{
    public class UssdInboundDTO
    {
        [DataMember(Name = "m")]
        public string Msisdn { get; set; }
        [DataMember(Name = "b")]
        public string Body { get; set; }
        [DataMember(Name = "s")]
        public string Sessionid { get; set; }
        [DataMember(Name = "t")]
        public string Type { get; set; }
    }
}

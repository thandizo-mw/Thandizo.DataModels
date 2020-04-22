using Newtonsoft.Json;

namespace Thandizo.DataModels.Ussd
{
    public class UssdInboundDTO
    {
        [JsonProperty("m")]
        public string Msisdn { get; set; }
        [JsonProperty("b")]
        public string Body { get; set; }
        [JsonProperty("s")]
        public string Sessionid { get; set; }
        [JsonProperty("t")]
        public string Type { get; set; }
    }
}

using Newtonsoft.Json;

namespace Thandizo.DataModels.Ussd
{
    public class UssdOutboundDTO
    {
        [JsonProperty("m")]
        public string Msisdn { get; set; }
        [JsonProperty("r")]
        public string Response { get; set; }
        [JsonProperty("s")]
        public string sessionid { get; set; }
        [JsonProperty("t")]
        public string Type { get; set; }
    }
}

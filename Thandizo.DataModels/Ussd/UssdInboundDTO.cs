using System.Text.Json.Serialization;

namespace Thandizo.DataModels.Ussd
{
    public class UssdInboundDTO
    {
        [JsonPropertyName("m")]
        public string Msisdn { get; set; }
        [JsonPropertyName("b")]
        public string Body { get; set; }
        [JsonPropertyName("s")]
        public string Sessionid { get; set; }
        [JsonPropertyName("t")]
        public string Type { get; set; }
    }
}

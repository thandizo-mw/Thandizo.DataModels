﻿namespace Thandizo.DataModels.Ussd
{
    public class UssdConfiguration
    {
        public string LanguageFolder { get; set; }
        public string RedisHostUrl { get; set; }
        public string PatientsApiUrl { get; set; }
        public string CoreApiUrl { get; set; }
        public string VirusTrackerApiUrl { get; set; }
        public string DhisApiUrl { get; set; }
        public string HfdApiUrl { get; set; }
        public string IdentityServerApiUrl { get; set; }
        public string IdentityServerClientId { get; set; }
        public string IdentityServerClientSecret { get; set; }
        public string IdentityServerScope { get; set; }
    }
}

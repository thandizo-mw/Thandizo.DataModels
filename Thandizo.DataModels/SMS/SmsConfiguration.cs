using System;
using System.Collections.Generic;
using System.Text;

namespace Thandizo.DataModels.SMS
{
    public class SmsConfiguration
    {
        public string SmsSender { get; set; }
        public string BaseUrl { get; set; }
        public string RapidProUserName { get; set; }
        public string RapidProPassword { get; set; }
        public string RapidProSmsCode { get; set; }
    }
}

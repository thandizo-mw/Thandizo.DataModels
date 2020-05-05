﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Thandizo.DataModels.Notifications.Responses
{
    public class ScheduledNotificationResponse : ScheduledNotificationDTO
    {
        public string TemplateName { get; set; }
        public string ChanneldName { get; set; }
        public string RuleName { get; set; }
        public string PatientName { get; set; }
    }
}

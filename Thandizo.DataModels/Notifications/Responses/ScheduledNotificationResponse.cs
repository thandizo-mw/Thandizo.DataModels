using System;
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
        public int TemplateInterval { get; set; }
        public string TemplateIntervalUnit { get; set; }
        public int TemplateRepeatCount { get; set; }
        public string RuleMessage { get; set; }
        public string EscalateTo { get; set; }
        public string IntervalName
        {
            get
            {
                return Interval switch
                {
                    "O" => "One Time",
                    "D" => "Daily",
                    "W" => "Weekly",
                    "M" => "Monthly",
                    _ => "None",
                };
            }
        }
    }
}

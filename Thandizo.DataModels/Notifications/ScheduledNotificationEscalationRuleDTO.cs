using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Notifications
{
    public class ScheduledNotificationEscalationRuleDTO : BaseRowDTO
    {
        public int RuleId { get; set; }

        [Required(ErrorMessage = "Name cannot be blank")]
        [MaxLength(60, ErrorMessage = "Maximum length for Name is 60")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "Message cannot be blank")]
        [MaxLength(1000, ErrorMessage = "Maximum length for Message is 1000")]
        public string Message { get; set; }

        [Display(Name = "Escalate To")]
        [Required(ErrorMessage = "Escalate To cannot be blank")]
        [MaxLength(200, ErrorMessage = "Maximum length for Escalate To is 200")]
        public string EscalateTo { get; set; }

    }
}

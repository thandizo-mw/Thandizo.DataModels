using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Thandizo.DataModels.General;
using Thandizo.DataModels.Validations;

namespace Thandizo.DataModels.Notifications
{
    public class ScheduledNotificationDTO : BaseRowDTO
    {
        public long NotificationId { get; set; }

        [Display(Name = "Recipients")]
        public string[] Recipients { get; set; }

        [Required(ErrorMessage = "Channel Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Channel Id")]
        [Display(Name = "Channel")]
        public int ChannelId { get; set; }

        [Required(ErrorMessage = "Escalation Rule Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Escalation Rule Id")]
        [Display(Name = "Escalation Rule")]
        public int RuleId { get; set; }

        [Required(ErrorMessage = "Notification Template Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Notification Template Id")]
        [Display(Name = "Notification Reminder")]
        public int TemplateId { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "Message cannot be blank")]
        [MaxLength(1000, ErrorMessage = "Maximum length for Message is 1000")]
        public string Message { get; set; }

        [Display(Name = "Is Active")]
        [Required(ErrorMessage = "Is Active cannot be blank")]
        [Range(typeof(bool), "False", "True", ErrorMessage = "Is Active has to either be true or false")]
        public bool IsActive { get; set; }

        [Required(ErrorMessage = "Interval cannot be blank")]
        [ExpectedStringValue("O,D,W,M", ErrorMessage = "Interval expects O, D, W, M values")]
        [MaxLength(1, ErrorMessage = "Maximum number of characters for Interval is 1")]
        [Display(Name = "Interval")]
        public string Interval{ get; set; }
               
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Start Date cannot be blank")]
        public DateTime StartDate { get; set; }
    }
}

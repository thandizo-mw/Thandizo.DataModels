using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Notifications
{
    public class BulkNotificationDTO : BaseRowDTO
    {
        public long NotificationId { get; set; }

        [Display(Name = "Message")]
        [Required(ErrorMessage = "Message cannot be blank")]
        [MaxLength(1000, ErrorMessage = "Maximum length for Message is 1000")]
        public string Message { get; set; }

        [Display(Name = "Send Date")]
        [Required(ErrorMessage = "Send Date cannot be blank")]
        public DateTime SendDate { get; set; }

        [Required(ErrorMessage = "Channel Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Channel Id")]
        [Display(Name = "Channel")]
        public int ChannelId { get; set; }



    }
}

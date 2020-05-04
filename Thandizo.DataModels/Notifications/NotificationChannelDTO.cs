using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Notifications
{
    public class NotificationChannelDTO : BaseRowDTO
    {
        public int ChannelId { get; set; }

        [Required(ErrorMessage="Channel Name cannot be blank")]
        [MaxLength(40, ErrorMessage="Maximum length for Channel Name is 40")]
        [Display(Name = "Name")]
        public string ChannelName { get; set; }
    }
}

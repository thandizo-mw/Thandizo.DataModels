using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Thandizo.DataModels.General;
using Thandizo.DataModels.Validations;

namespace Thandizo.DataModels.Notifications
{
    public class BulkNotificationLogDTO : DataCreatorDTO
    {
        public long NotificationLogId { get; set; }

        [Required(ErrorMessage = "Notification Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid number for Notification Id")]
        [Display(Name = "Notification")]
        public long NotificationId { get; set; }


        [Display(Name = "Phone Number")]
        [MaxLength(20, ErrorMessage = "Maximum length for Phone Number is 20")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Status cannot be blank")]
        [ExpectedStringValue("S,D,R,E", ErrorMessage = "Status expects either S, D, R or E values")]
        [MaxLength(1, ErrorMessage = "Maximum number of characters for Status is 1")]
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}

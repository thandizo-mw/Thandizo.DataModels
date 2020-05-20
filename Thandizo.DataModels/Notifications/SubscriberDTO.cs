using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Notifications
{
    public class SubscriberDTO : BaseRowDTO
    {
        public int SubscriberId { get; set; }

        [Required(ErrorMessage="Channel Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Channel Id")]
        [Display(Name = "Channel")]
        public int ChannelId { get; set; }


        [Display(Name = "Recipient Address")]
        [Required(ErrorMessage = "Recipient Address cannot be blank")]
        [MaxLength(60, ErrorMessage = "Maximum length for Recipient Address is 60")]
        public string RecipientAddress { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number cannot be blank")]
        [MaxLength(20, ErrorMessage = "Maximum length for Phone Number is 20")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Subscription Date")]
        [Required(ErrorMessage = "Subscription Date cannot be blank")]
        public DateTime SubscriptionDate { get; set; }
    }
}

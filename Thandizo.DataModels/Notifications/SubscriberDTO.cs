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


        [Display(Name = "Phone Number")]
        [MaxLength(20, ErrorMessage = "Maximum length for Phone Number is 20")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Is Registered Patient")]
        [Required(ErrorMessage = "Is Registered cannot be blank")]
        [Range(typeof(bool), "False", "True", ErrorMessage = "Is Registered Patient has to either be true or false")]
        public bool IsRegisteredPatient { get; set; }
    }
}

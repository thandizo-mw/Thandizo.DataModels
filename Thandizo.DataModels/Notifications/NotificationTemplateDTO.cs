using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Thandizo.DataModels.General;
using Thandizo.DataModels.Validations;

namespace Thandizo.DataModels.Notifications
{
    public class NotificationTemplateDTO : BaseRowDTO
    {
        public int TemplateId { get; set; }


        [Required(ErrorMessage = "Template Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum length for Template Name is 40")]
        [Display(Name = "Template Name")]
        public string TemplateName { get; set; }

        [Required(ErrorMessage = "Interval cannot be blank")]
        [Range(1, 60, ErrorMessage = "Interval should be between 1 and 60")]
        [Display(Name = "Interval")]
        public int Interval { get; set; }

        [Required(ErrorMessage = "Interval Unit cannot be blank")]
        [ExpectedStringValue("M,H", ErrorMessage = "Interval Unit expects M or H values")]
        [MaxLength(1, ErrorMessage = "Maximum number of characters for Interval Unit is 1")]
        [Display(Name = "Interval Unit")]
        public string IntervalUnit { get; set; }
        
        [Required(ErrorMessage = "Repeat Count cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Repeat Count")]
        [Display(Name = "Repeat Count")]
        public int RepeatCount { get; set; }
    }
}

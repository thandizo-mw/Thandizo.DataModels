using System;
using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.General
{
    public abstract class DataCreatorDTO
    {
        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Created By cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Created By is 40")]
        public string CreatedBy { get; set; }
    }
}

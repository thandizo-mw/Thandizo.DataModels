using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public class IdentificationTypeDTO : BaseRowDTO
    {
        public int IdentificationTypeId { get; set; }

        [Required(ErrorMessage = "Description cannot be blank")]
        [MaxLength(30, ErrorMessage = "Maximum number of characters for Description is 30")]
        public string Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public class IdentificationTypeDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "Identification Type Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Identification Type Id")]
        public int IdentificationTypeId { get; set; }

        [Required(ErrorMessage = "Description cannot be blank")]
        [MaxLength(30, ErrorMessage = "Maximum number of characters for Description is 30")]
        public string Description { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Resources
{
    public class ResourceDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "Resource Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Resource Id")]
        public int ResourceId { get; set; }

        [Required(ErrorMessage = "Resource Name cannot be blank")]
        [MaxLength(50, ErrorMessage = "Maximum length for Resource Name is 50")]
        public string ResourceName { get; set; }
    }
}

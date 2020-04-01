using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Resources
{
    public class ResourceDTO : BaseRowDTO
    {
        public int ResourceId { get; set; }

        [Required(ErrorMessage = "Resource Name cannot be blank")]
        [MaxLength(50, ErrorMessage = "Maximum length for Resource Name is 50")]
        public string ResourceName { get; set; }
    }
}

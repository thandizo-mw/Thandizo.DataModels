using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public class RegionDTO :BaseRowDTO
    {
        [Required(ErrorMessage = "Region Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Region Id")]
        public int RegionId { get; set; }

        [Required(ErrorMessage = "Region Name cannot be blank")]
        [MaxLength(30, ErrorMessage = "Maximum number of characters for Region Name is 30")]
        public string RegionName { get; set; }
    }
}

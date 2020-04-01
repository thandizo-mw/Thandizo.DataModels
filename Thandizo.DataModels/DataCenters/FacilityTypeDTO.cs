using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.DataCenters
{
    public class FacilityTypeDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "Facility Type Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Facility Type Id")]
        public int FacilityTypeId { get; set; }

        [Required(ErrorMessage = "Facility Type Name cannot be blank")]
        [MaxLength(100, ErrorMessage = "Maximum number of characters for Facility Type Name is 100")]
        public string FacilityTypeName { get; set; }
    }
}

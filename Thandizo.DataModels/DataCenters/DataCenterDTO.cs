using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.DataCenters
{
    public class DataCenterDTO : BaseRowDTO
    {
        public int CenterId { get; set; }

        [Required(ErrorMessage = "Center Name cannot be blank")]
        [MaxLength(70, ErrorMessage = "Maximum number of characters for Center Name is 70")]
        public string CenterName { get; set; }

        [Required(ErrorMessage = "Facility Type Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Facility Type Id")]
        public int FacilityTypeId { get; set; }

        [Required(ErrorMessage = "District Code cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for District Code is 2")]
        [MaxLength(3, ErrorMessage = "Maximum number of characters for District Code is 3")]
        public string DistrictCode { get; set; }

        [Required(ErrorMessage = "Is Health Facility cannot be blank")]
        [Range (typeof(bool), "False", "True", ErrorMessage = "Is Health Facility has to either be true or false")]
        public bool IsHealthFacility { get; set; }
    }
}

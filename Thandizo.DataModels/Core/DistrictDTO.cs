using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public  class DistrictDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "District Code cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for District Code is 2")]
        [MaxLength(3, ErrorMessage = "Maximum number of characters for District Code is 3")]
        public string DistrictCode { get; set; }


        [Required(ErrorMessage = "District Name cannot be blank")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters for District Name is 50")]
        public string DistrictName { get; set; }


        [Required(ErrorMessage = "Region Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Region Id")]
        public int RegionId { get; set; }


        [Required(ErrorMessage = "Latitude cannot be blank")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters for Latitude is 50")]
        public string Latitude { get; set; }


        [Required(ErrorMessage = "Longitude Code cannot be blank")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters for Longitude is 50")]
        public string Longitude { get; set; }
    }
}

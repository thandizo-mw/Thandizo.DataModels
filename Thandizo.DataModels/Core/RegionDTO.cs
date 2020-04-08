using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public class RegionDTO :BaseRowDTO
    {
        public int RegionId { get; set; }

        [Required(ErrorMessage = "Region Name cannot be blank")]
        [MaxLength(30, ErrorMessage = "Maximum number of characters for Region Name is 30")]
        public string RegionName { get; set; }

        [Required(ErrorMessage = "Latitude cannot be blank")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Longitude Code cannot be blank")]
        public double Longitude { get; set; }
    }
}

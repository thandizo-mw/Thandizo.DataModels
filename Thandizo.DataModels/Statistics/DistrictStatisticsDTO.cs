using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.Statistics
{
    public class DistrictStatisticsDTO : RegionalStatisticsDTO
    {
        [Required(ErrorMessage = "District Name cannot be blank")]
        [MaxLength(50, ErrorMessage = "Maximum length for District Name is 50")]
        public string DistrictName { get; set; }
    }
}
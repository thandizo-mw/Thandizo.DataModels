using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Thandizo.DataModels.Statistics
{
    public class RegionalStatisticsDTO : NationalStatisticsDTO
    {
        [Required(ErrorMessage = "Region Name cannot be blank")]
        [MaxLength(30, ErrorMessage = "Maximum length for Region Name is 30")]
        public string RegionName { get; set; }
    }
}

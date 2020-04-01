
using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.DataCenters
{
    public class HealthFacilityResourceDTO : BaseRowDTO
    {
        public int FacilityResourceId { get; set; }

        [Required(ErrorMessage = "Center Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Center Id")]
        public int CenterId { get; set; }

        [Required(ErrorMessage = "Resource Allocation Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid number for Resource Allocation Id")]
        public long ResourceAllocationId { get; set; }

        [Required(ErrorMessage = "Quantity cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Quantity")]
        public int Quantity { get; set; }
    }
}

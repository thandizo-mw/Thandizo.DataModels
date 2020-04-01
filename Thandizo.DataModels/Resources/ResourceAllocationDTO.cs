using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Resources
{
    public class ResourceAllocationDTO : BaseRowDTO
    {
        [Required(ErrorMessage = "Resource Allocation Id cannot be blank")]
        [Range(1, long.MaxValue, ErrorMessage = "Please enter valid integer number for Resource Allocation Id")]
        public long ResourceAllocationId { get; set; }

        [Required(ErrorMessage = "Patient Status Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Patient Status Id")] 
        public int PatientStatusId { get; set; }

        [Required(ErrorMessage = "Resource Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Resource Id")]
        public int ResourceId { get; set; }

        [Required(ErrorMessage = "Required Quantity cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Required Quantity")]
        public int RequiredQuantity { get; set; }
    }
}

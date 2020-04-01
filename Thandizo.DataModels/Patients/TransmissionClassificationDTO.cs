using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class TransmissionClassificationDTO : BaseRowDTO
    {
        public int ClassificationId { get; set; }

        [Required(ErrorMessage = "Classification Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum length for Classification Name is 40")]
        public string ClassificationName { get; set; }
    }
}

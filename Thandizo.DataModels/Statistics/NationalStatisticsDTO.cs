using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.Statistics
{
    public class NationalStatisticsDTO
    {
        [Required(ErrorMessage = "Patient Status Name cannot be blank")]
        [MaxLength(50, ErrorMessage = "Maximum length for Patient Status Name is 50")]
        public string PatientStatusName { get; set; }
        public int TotalNumberOfPatients { get; set; }
    }
}

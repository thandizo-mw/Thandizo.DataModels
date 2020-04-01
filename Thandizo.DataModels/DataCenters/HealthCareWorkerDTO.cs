using System;
using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;
using Thandizo.DataModels.Validations;

namespace Thandizo.DataModels.DataCenters
{
    public class HealthCareWorkerDTO : BaseRowDTO
    {
        public int WorkerId { get; set; }

        [Required(ErrorMessage = "First Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for First Name is 40")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Last Name is 40")]
        public string LastName { get; set; }

        [MaxLength(40, ErrorMessage = "Maximum number of characters for Other Names is 40")]
        public string OtherNames { get; set; }

        [Required(ErrorMessage = "Gender cannot be blank")]
        [ExpectedStringValue("M,F", ErrorMessage = "Period Type expects M, F values")]
        [MaxLength(1, ErrorMessage = "Maximum number of characters for Gender is 1")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Date Of Birth cannot be blank")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Data Center Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Data Center Id")]
        public int DataCenterId { get; set; }

        [MaxLength(20, ErrorMessage = "Maximum length for Phone number is 20")]
        public string PhoneNumber { get; set; }

        [EmailAddress(ErrorMessage = "Must be a valid Email Address")]
        [MaxLength(60, ErrorMessage = "Maximum length for Email Address is 60")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Identification Number cannot be blank")]
        [MaxLength(25, ErrorMessage = "Maximum length for Identification Number is 25")]
        public string IdentificationNumber { get; set; }

        [Required(ErrorMessage = "Identification Type Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Identification Type Id")]
        public int IdentificationTypeId { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;
using Thandizo.DataModels.Validations;

namespace Thandizo.DataModels.Patients
{
    public class PatientDTO : BaseRowDTO
    {
        public long PatientId { get; set; }

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

        [MaxLength(200, ErrorMessage = "Maximum number of characters for Home Address is 200")]
        public string HomeAddress { get; set; }

        [MaxLength(200, ErrorMessage = "Maximum number of characters for physical Address is 200")]
        public string PhysicalAddress { get; set; }

        [Required(ErrorMessage = "District Code cannot be blank")]
        [MaxLength(3, ErrorMessage = "Maximum number of characters for District Code is 3")]
        public string DistrictCode { get; set; }

        [EmailAddress(ErrorMessage = "Must be a valid Email Address")]
        [MaxLength(60, ErrorMessage = "Maximum length for Email Address is 60")]
        public string EmailAddress { get; set; }

        [MaxLength(20, ErrorMessage = "Maximum length for Phone Number is 20")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Identification Number cannot be blank")]
        [MaxLength(25, ErrorMessage = "Maximum length for Identification Number is 25")]
        public string IdentificationNumber { get; set; }
        
        [Required(ErrorMessage = "Identification Type Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Identification Type Id")]
        public int IdentificationTypeId { get; set; }

        [Required(ErrorMessage = "Data Center Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Data Center Id")]
        public int DataCenterId { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum number of characters for Latitude is 50")]
        public string Latitude { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum number of characters for Longitude is 50")]
        public string Longitude { get; set; }

        [Required(ErrorMessage = "Patient Status Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Patient Status Id")]
        public int PatientStatusId { get; set; }

        [Required(ErrorMessage = "Nationality Code cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for Nationality Code is 2")]
        [MaxLength(5, ErrorMessage = "Maximum number of characters for Nationality Code is 5")]
        public string NationalityCode { get; set; }

        [Required(ErrorMessage = "Classification Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Classification Id")]
        public int ClassificationId { get; set; }

        [Required(ErrorMessage = "Source Id cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for Source Id is 2")]
        [MaxLength(2, ErrorMessage = "Maximum number of characters for Source Id is 2")]
        public string SourceId { get; set; }

        public bool IsConfirmed { get; set; }
    }
}

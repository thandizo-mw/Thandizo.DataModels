using System;
using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;
using Thandizo.DataModels.Validations;

namespace Thandizo.DataModels.Patients
{
    public class PatientDTO : BaseRowDTO
    {
        [Display(Name = "Patient Id")]
        public long PatientId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for First Name is 40")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Last Name is 40")]
        public string LastName { get; set; }

        [Display(Name = "Other Names")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Other Names is 40")]
        public string OtherNames { get; set; }

        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Gender cannot be blank")]
        [ExpectedStringValue("M,F", ErrorMessage = "Gender expects M, F values")]
        [MaxLength(1, ErrorMessage = "Maximum number of characters for Gender is 1")]
        public string Gender { get; set; }

        [Display(Name = "Date Of Birth")]
        [Required(ErrorMessage = "Date Of Birth cannot be blank")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Home Address")]
        [MaxLength(200, ErrorMessage = "Maximum number of characters for Home Address is 200")]
        public string HomeAddress { get; set; }

        [Display(Name = "Physical Address")]
        [MaxLength(200, ErrorMessage = "Maximum number of characters for physical Address is 200")]
        public string PhysicalAddress { get; set; }

        [Display(Name = "District Code")]
        [Required(ErrorMessage = "District Code cannot be blank")]
        [MaxLength(3, ErrorMessage = "Maximum number of characters for District Code is 3")]
        public string DistrictCode { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Must be a valid Email Address")]
        [MaxLength(60, ErrorMessage = "Maximum length for Email Address is 60")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        [MaxLength(20, ErrorMessage = "Maximum length for Phone Number is 20")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Identification Number")]
        [Required(ErrorMessage = "Identification Number cannot be blank")]
        [MaxLength(25, ErrorMessage = "Maximum length for Identification Number is 25")]
        public string IdentificationNumber { get; set; }

        [Display(Name = "Identification Type Id")]
        [Required(ErrorMessage = "Identification Type Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Identification Type Id")]
        public int IdentificationTypeId { get; set; }

        [Display(Name = "Data Center Id")]
        public int DataCenterId { get; set; }

        [Display(Name = "Latitude")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters for Latitude is 50")]
        public string Latitude { get; set; }

        [Display(Name = "Longitude")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters for Longitude is 50")]
        public string Longitude { get; set; }

        [Display(Name = "Patiet Status Id")]
        public int PatientStatusId { get; set; }

        [Display(Name = "Nationality Code")]
        [Required(ErrorMessage = "Nationality Code cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for Nationality Code is 2")]
        [MaxLength(5, ErrorMessage = "Maximum number of characters for Nationality Code is 5")]
        public string NationalityCode { get; set; }

        [Display(Name = "Classification Id")]
        public int ClassificationId { get; set; }

        [Display(Name = "Source Id")]
        [Required(ErrorMessage = "Source Id cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for Source Id is 2")]
        [MaxLength(2, ErrorMessage = "Maximum number of characters for Source Id is 2")]
        public string SourceId { get; set; }

        [Display(Name = "Is COnfirmed?")]
        public bool IsConfirmed { get; set; }

        [Display(Name = "Next of Kin First Name")]
        [Required(ErrorMessage = "Next of Kin First Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Next of Kin First Name is 40")]
        public string NextOfKinFirstName { get; set; }

        [Display(Name = "Next of Kin Last Name")]
        [Required(ErrorMessage = "Next of Kin Last Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Next of Kin Last Name is 40")]
        public string NextOfKinLastName { get; set; }

        [Display(Name = "Next Of Kin Phone Number")]
        [Required(ErrorMessage = "Last Name cannot be blank")]
        [MaxLength(15, ErrorMessage = "Maximum number of characters for Next Of Kin Phone Number is 15")]
        public string NextOfKinPhoneNumber { get; set; }

        [Display(Name = "Country Code")]
        [Required(ErrorMessage = "Country Code cannot be blank")]
        [MaxLength(3, ErrorMessage = "Maximum number of characters for Country Code is 3")]
        public string ResidenceCountryCode { get; set; }

        [Display(Name = "Is Self Registered?")]
        [Required(ErrorMessage = "Is Self Registered cannot be blank")]
        public bool IsSelfRegistered { get; set; }

        [Display(Name = "External Reference Number")]
        public string ExternalReferenceNumber { get; set; }
    }
}

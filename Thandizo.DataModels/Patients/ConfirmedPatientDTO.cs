using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Thandizo.DataModels.Validations;

namespace Thandizo.DataModels.Patients
{
    public class ConfirmedPatientDTO
    {
        public long ConfirmedPatientId { get; set; }

        [Required(ErrorMessage = "Patient Id cannot be blank")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid integer number for Patient Id ")]
        public long PatientId { get; set; }

        [Required(ErrorMessage = "First Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for First Name is 40")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name cannot be blank")]
        [MaxLength(40, ErrorMessage = "Maximum number of characters for Last Name is 40")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Gender cannot be blank")]
        [ExpectedStringValue("M,F", ErrorMessage = "Period Type expects M, F values")]
        [MaxLength(1, ErrorMessage = "Maximum number of characters for Gender is 1")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Date Of Birth cannot be blank")]
        public DateTime DateOfBirth { get; set; }

        [MaxLength(20, ErrorMessage = "Maximum length for Phone Number is 20")]
        public string PhoneNumber { get; set; }

        [MaxLength(40, ErrorMessage = "Maximum number of characters for First Name is 40")]
        public string GuardianFirstName { get; set; }

        [MaxLength(40, ErrorMessage = "Maximum number of characters for Last Name is 40")]
        public string GuardianSurName { get; set; }

        [MaxLength(20, ErrorMessage = "Maximum length for Phone Number is 20")]
        public string GuardianPhoneNumber { get; set; }

        [Required(ErrorMessage = "Identification Number cannot be blank")]
        [MaxLength(25, ErrorMessage = "Maximum length for Identification Number is 25")]
        public string IdentificationNumber { get; set; }

        [Required(ErrorMessage = "Identification Type cannot be blank")]
        [MaxLength(5, ErrorMessage = "Maximum number of characters for Identification Type is 5")]
        public string IdentificationType { get; set; }
        
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid number for Age")]
        public int age { get; set; }

        [Required(ErrorMessage = "Country Code cannot be blank")]
        [MinLength(2, ErrorMessage = "Minimum number of characters for Country Code is 2")]
        [MaxLength(3, ErrorMessage = "Maximum number of characters for Country Code is 3")]
        public string CountryCode { get; set; }

    }
}

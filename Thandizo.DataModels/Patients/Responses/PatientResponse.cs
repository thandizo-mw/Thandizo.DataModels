using System;
using System.ComponentModel.DataAnnotations;

namespace Thandizo.DataModels.Patients.Responses
{
    public class PatientResponse : PatientDTO
    {
        [Display(Name = "Patient Status")]
        public string PatientStatusName { get; set; }

        [Display(Name = "District")]
        public string DistrictName { get; set; }

        [Display(Name = "Identitification Type")]
        public string IdentitificationTypeName { get; set; }

        [Display(Name = "Nationality")]
        public string NationalityName { get; set; }

        [Display(Name = "Transmission Classification")]
        public string ClassificationName { get; set; }
        
        [Display(Name = "Source")]
        public string SourceName { get; set; }

        [Display(Name = "Age")]
        public int Age
        {
            get
            {
                var age = DateTime.Now.Year - DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear)
                    age = age - 1;
                return age;
            }
        }

        [Display(Name = "Gender")]
        public string GenderName
        {
            get
            {
                var genderName = Gender.Equals("F")?"Female":"Male";
                return genderName;
            }
        }
    }
}

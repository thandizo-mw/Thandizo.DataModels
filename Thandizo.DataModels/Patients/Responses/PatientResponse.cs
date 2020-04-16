using System;

namespace Thandizo.DataModels.Patients.Responses
{
    public class PatientResponse : PatientDTO
    {
        public string PatientStatusName { get; set; }
        public string DistrictName { get; set; }
        public string IdentitificationTypeName { get; set; }
        public string NationalityName { get; set; }
        public string ClassificationName { get; set; }
        public string SourceName { get; set; }
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

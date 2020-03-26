using System;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Patients
{
    public class PatientDTO : BaseRowDTO
    {
        public long PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HomeAddress { get; set; }
        public string PhysicalAddress { get; set; }
        public string DistrictCode { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public int IdentificationTypeId { get; set; }
        public int DataCenterId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int PatientStatusId { get; set; }
    }
}

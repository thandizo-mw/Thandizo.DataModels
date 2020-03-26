using System;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.DataCenters
{
    public class HealthCareWorkerDTO : BaseRowDTO
    {
        public int WorkerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OtherNames { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DataCenterId { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IdentificationNumber { get; set; }
        public int IdentificationTypeId { get; set; }
    }
}

﻿using System;

namespace Thandizo.DataModels.Integrations
{
    public class DhisPatientIntegrationDTO
    {
        public int PatientAge { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string NationalId { get; set; }
        public string PassportNumber { get; set; }
        public string HomeAddress { get; set; }
        public string NextOfKinLastName { get; set; }
        public string NextOfKinFirstName { get; set; }
        public string NextOfKinPhoneNumber { get; set; }
        public string OtherIdentificationNumber { get; set; }
        public string NationalityName { get; set; }
        public string CountryName { get; set; }
    }
}
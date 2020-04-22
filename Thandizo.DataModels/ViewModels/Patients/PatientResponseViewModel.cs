using System;
using System.Collections.Generic;
using System.Text;
using Thandizo.DataModels.Core;
using Thandizo.DataModels.Patients;
using Thandizo.DataModels.Patients.Responses;

namespace Thandizo.DataModels.ViewModels.Patients
{
    public class PatientResponseViewModel
    {
        public PatientResponse PatientResponse { get; set; }
        public IEnumerable<PatientStatusDTO> PatientStatuses { get; set; }
        public IEnumerable<IdentificationTypeDTO> IdentificationTypes { get; set; }
        public IEnumerable<TransmissionClassificationDTO> TransmissionClassifications { get; set; }
    }
}

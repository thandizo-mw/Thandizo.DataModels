using System;
using System.Collections.Generic;
using System.Text;
using Thandizo.DataModels.Core;
using Thandizo.DataModels.DataCenters.Responses;

namespace Thandizo.DataModels.ViewModels.DataCenters
{
    public class HealthCareWorkerResponseViewModel
    {
        public HealthCareWorkerResponse HealthCareWorkerResponse { get; set; }
        public IEnumerable<IdentificationTypeDTO> IdentificationTypes { get; set; }
    }
}

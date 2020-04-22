using System;
using System.Collections.Generic;
using System.Text;
using Thandizo.DataModels.Core;
using Thandizo.DataModels.DataCenters;
using Thandizo.DataModels.DataCenters.Responses;

namespace Thandizo.DataModels.ViewModels.DataCenters
{
    public class DataCenterResponseViewModel
    {
        public DataCenterResponse DataCenterResponse { get; set; }
        public IEnumerable<DistrictDTO> Districts { get; set; }

        public IEnumerable<FacilityTypeDTO> FacilityTypes { get; set; }
    }
}

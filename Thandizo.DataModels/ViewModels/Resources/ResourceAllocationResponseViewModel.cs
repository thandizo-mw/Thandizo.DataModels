using System;
using System.Collections.Generic;
using System.Text;
using Thandizo.DataModels.Resources;
using Thandizo.DataModels.Resources.Responses;

namespace Thandizo.DataModels.ViewModels.Resources
{
    public class ResourceAllocationResponseViewModel
    {
        public ResourceAllocationResponse ResourceAllocationResponse { get; set; }

        public IEnumerable<ResourceDTO> Resources { get; set; }
    }
}

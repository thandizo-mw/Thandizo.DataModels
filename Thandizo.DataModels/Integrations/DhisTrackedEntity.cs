using System.Collections.Generic;

namespace Thandizo.DataModels.Integrations
{
    public class DhisTrackedEntity
    {
        public string TrackedEntity { get; set; }
        public string OrgUnit { get; set; }
        public IEnumerable<DhisTrackedEntityAttribute> Attributes { get; set; }
    }
}

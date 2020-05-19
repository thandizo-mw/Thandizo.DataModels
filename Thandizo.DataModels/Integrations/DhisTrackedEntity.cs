using System.Collections.Generic;

namespace Thandizo.DataModels.Integrations
{
    public class DhisTrackedEntity
    {
        public string TrackedEntityType { get; set; }
        public string OrgUnit { get; set; }
        public IEnumerable<DhisTrackedEntityAttribute> Attributes { get; set; }
        public IEnumerable<DhisEnrollment> Enrollments { get; set; }
    }
}

using System.Collections.Generic;

namespace Thandizo.DataModels.Integrations.Responses
{
    public class ImportSummaryResponse
    {
        public string ResponseType { get; set; }
        public string Status { get; set; }
        public ImportCountResponse ImportCount { get; set; }
        public IEnumerable<ConflictResponse> Conflicts { get; set; }
        public EnrollmentResponse Enrollments { get; set; }
    }
}

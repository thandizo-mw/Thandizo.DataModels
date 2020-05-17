using System.Collections.Generic;

namespace Thandizo.DataModels.Integrations.Responses
{
    public class ImportResponse : EnrollmentResponse
    {
        public IEnumerable<ImportSummaryResponse> ImportSummaries { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Thandizo.DataModels.Integrations.Responses
{
    public class ImportCountResponse
    {
        public int Imported { get; set; }
        public int Updated { get; set; }
        public int Deleted { get; set; }
        public int Ignored { get; set; }
    }
}

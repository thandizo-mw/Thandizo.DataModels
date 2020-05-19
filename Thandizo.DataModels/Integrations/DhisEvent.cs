using System;
using System.Collections.Generic;

namespace Thandizo.DataModels.Integrations
{
    public class DhisEvent
    {
        public string Program { get; set; }
        public string OrgUnit { get; set; }
        public DateTime EventDate { get; set; }
        public string Status { get; set; }
        public string StoredBy { get; set; }
        public string ProgramStage { get; set; }
        public IEnumerable<DhisDataValue> DataValues { get; set; }
    }
}

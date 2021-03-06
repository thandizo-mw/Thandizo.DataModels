﻿using System;
using System.Collections.Generic;

namespace Thandizo.DataModels.Integrations
{
    public class DhisEnrollment
    {
        public string OrgUnit { get; set; }
        public string Program { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public DateTime IncidentDate { get; set; }
        public IEnumerable<DhisEvent> Events { get; set; }
    }
}

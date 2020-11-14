﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BsButtonApi.ViewModels
{
    public class BsVerifyViewModel
    {
        public int ReportId { get; set; }

        public Guid ReportGuid { get; set; }

        public string ReporterUserName { get; set; }

        public string ReportedName { get; set; }

        public string ReportedFrom { get; set; }

        public DateTime ReportedDateTime { get; set; }

        public string ReportReason { get; set; }

        public string ReportText { get; set; }

        public bool Verified { get; set; }

    }
}

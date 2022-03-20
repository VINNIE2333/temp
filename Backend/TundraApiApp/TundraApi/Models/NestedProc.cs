using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class NestedProc
    {
        public int Counter { get; set; }
        public string? PmNum { get; set; }
        public string? ProcNum { get; set; }
        public decimal? Pminterval { get; set; }
        public decimal? IntervalDue { get; set; }
        public decimal? Pmsequence { get; set; }
        public DateTime? Creationdate { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Modifydate { get; set; }
        public string? Modifyby { get; set; }
        public decimal Dirtylog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

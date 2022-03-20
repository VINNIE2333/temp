using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class PmoffSeason
    {
        public string Pmnum { get; set; } = null!;
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
        public int Counter { get; set; }
        public DateTime? Modifydate { get; set; }
        public DateTime? Creationdate { get; set; }
        public string? Modifyby { get; set; }
        public string? Createdby { get; set; }
        public decimal? Dirtylog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPhasebalance
    {
        public string Id { get; set; } = null!;
        public string Projectid { get; set; } = null!;
        public string Phase { get; set; } = null!;
        public decimal Budget { get; set; }
        public string? Manager { get; set; }
        public string? Prjtype { get; set; }
        public decimal? PhaseBalance { get; set; }
    }
}

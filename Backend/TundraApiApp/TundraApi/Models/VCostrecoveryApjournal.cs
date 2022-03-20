using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VCostrecoveryApjournal
    {
        public string WoNum { get; set; } = null!;
        public string? Draccount { get; set; }
        public decimal? TotalCost { get; set; }
        public DateTime? Compdate { get; set; }
        public string? WoType { get; set; }
        public string? Status { get; set; }
        public string? AcctNum { get; set; }
        public string? Fund { get; set; }
        public string? Dept { get; set; }
        public string? Program { get; set; }
        public string? Class { get; set; }
        public string? Project { get; set; }
        public string FullWoNum { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public string ChargeType { get; set; } = null!;
        public string Ledger { get; set; } = null!;
    }
}

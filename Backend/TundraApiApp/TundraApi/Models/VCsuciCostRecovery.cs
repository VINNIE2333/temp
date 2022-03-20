using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VCsuciCostRecovery
    {
        public string WoNum { get; set; } = null!;
        public string? Draccount { get; set; }
        public decimal TotalCost { get; set; }
    }
}

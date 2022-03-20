using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VFundrecovery
    {
        public string? WoNum { get; set; }
        public decimal? Totalcost { get; set; }
        public decimal? ChargeBack { get; set; }
        public string ActualType { get; set; } = null!;
    }
}

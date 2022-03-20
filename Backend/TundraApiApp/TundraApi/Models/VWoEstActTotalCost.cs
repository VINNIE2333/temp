using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VWoEstActTotalCost
    {
        public string WoNum { get; set; } = null!;
        public decimal EstHours { get; set; }
        public decimal? EstTotalCost { get; set; }
        public decimal ActHours { get; set; }
        public decimal? ActTotalCost { get; set; }
    }
}

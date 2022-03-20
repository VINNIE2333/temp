using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VWoCostAccount
    {
        public int Counter { get; set; }
        public string? LinkId { get; set; }
        public string? Account { get; set; }
        public decimal? CostPercent { get; set; }
        public decimal? CostAmount { get; set; }
        public decimal? AccountCost { get; set; }
        public string? Description { get; set; }
        public decimal Keeppercent { get; set; }
        public string? LinkType { get; set; }
    }
}

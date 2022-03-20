using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInventory
    {
        public string Itemnum { get; set; } = null!;
        public string? Itemdesc { get; set; }
        public string Storeroom { get; set; } = null!;
        public decimal Stocklevel { get; set; }
        public string? Division { get; set; }
    }
}

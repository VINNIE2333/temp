using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInventoryPosition
    {
        public string ItemNum { get; set; } = null!;
        public string StoreRoom { get; set; } = null!;
        public string Position { get; set; } = null!;
        public decimal? QtyOnHand { get; set; }
        public string? ItemDesc { get; set; }
        public string? IssueUnit { get; set; }
        public string? Category { get; set; }
        public string? Vendor { get; set; }
        public string? Manufacturer { get; set; }
        public decimal Serialized { get; set; }
        public decimal Warranty { get; set; }
    }
}

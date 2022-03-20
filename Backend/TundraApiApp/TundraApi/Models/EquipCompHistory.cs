using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class EquipCompHistory
    {
        public string Equipment { get; set; } = null!;
        public string ItemNum { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal IsInventory { get; set; }
        public string? IssueUnit { get; set; }
    }
}

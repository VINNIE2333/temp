using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VReservedItem
    {
        public decimal Counter { get; set; }
        public string ItemNum { get; set; } = null!;
        public string StoreRoom { get; set; } = null!;
        public string ChargeTo { get; set; } = null!;
        public decimal QtyReserved { get; set; }
        public decimal Quantity { get; set; }
        public decimal? IssuedQty { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string LinkType { get; set; } = null!;
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ItemDesc { get; set; }
        public string? IssueUnit { get; set; }
        public decimal Serialized { get; set; }
        public decimal? QtyOnHand { get; set; }
        public decimal LineCounter { get; set; }
    }
}

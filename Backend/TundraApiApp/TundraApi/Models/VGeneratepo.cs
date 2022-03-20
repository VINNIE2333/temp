using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VGeneratepo
    {
        public string ItemNum { get; set; } = null!;
        public string StoreRoom { get; set; } = null!;
        public string? DrAccount { get; set; }
        public decimal MaxStock { get; set; }
        public decimal MinStock { get; set; }
        public string? ReorderMethod { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public decimal Inactive { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int Counter { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public string? Defvendor { get; set; }
        public string? Defmanufacturer { get; set; }
        public string? CrAccount { get; set; }
        public decimal? QtyOnHand { get; set; }
        public string? Division { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal LastPrice { get; set; }
        public string? ItemDesc { get; set; }
        public string? VendorPart { get; set; }
        public decimal Serialized { get; set; }
        public string? IssueUnit { get; set; }
        public string IssueMethod { get; set; } = null!;
        public string IssuePrice { get; set; } = null!;
        public decimal FixPrice { get; set; }
        public decimal? QuotedPrice { get; set; }
        public decimal? QtyReserved { get; set; }
        public string Defposition { get; set; } = null!;
        public decimal? QtyOnOrder { get; set; }
        public string? Category { get; set; }
        public decimal? QtyOnApprovedPo { get; set; }
        public decimal? Color { get; set; }
        public string? Polist { get; set; }
    }
}

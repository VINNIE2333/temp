using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Inventory
    {
        public string ItemNum { get; set; } = null!;
        public string StoreRoom { get; set; } = null!;
        public string? Aisle { get; set; }
        public string? InvRowNum { get; set; }
        public string? BinNum { get; set; }
        public string? IssueUnit { get; set; }
        public string? Vendor { get; set; }
        public string? Manufacturer { get; set; }
        public string? Account { get; set; }
        public string? LotNum { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal LastPrice { get; set; }
        public decimal QuotedPrice { get; set; }
        public decimal StockLevel { get; set; }
        public decimal MaxStock { get; set; }
        public decimal MinStock { get; set; }
        public string? ReorderMethod { get; set; }
        public decimal QtyOnOrder { get; set; }
        public decimal QtyReserved { get; set; }
        public decimal BackOrder { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public decimal Inactive { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int Counter { get; set; }
        public string? ItemDesc { get; set; }
        public decimal LastCount { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public decimal LotPrice { get; set; }
    }
}

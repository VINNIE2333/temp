using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInventoryIssue
    {
        public decimal Counter { get; set; }
        public string? LotNum { get; set; }
        public string ItemNum { get; set; } = null!;
        public string StoreRoom { get; set; } = null!;
        public string Position { get; set; } = null!;
        public decimal StockLevel { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public decimal Inactive { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal LastCount { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public decimal Quantity { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal AddCost { get; set; }
        public decimal Totalcost { get; set; }
        public decimal Price { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string? Vendor { get; set; }
        public string? SerialNum { get; set; }
        public string? VendorLot { get; set; }
        public decimal FixPrice { get; set; }
        public decimal? Cost { get; set; }
        public decimal? QuotedPrice { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal LastPrice { get; set; }
        public decimal? TransCounter { get; set; }
        public string? Equipment { get; set; }
        public decimal OriginalQuantity { get; set; }
    }
}

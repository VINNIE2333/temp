using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInventoryLot
    {
        public string? ItemDesc { get; set; }
        public decimal Cost { get; set; }
        public string? Vendor { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public string? Manufacturer { get; set; }
        public decimal Counter { get; set; }
        public string? LotNum { get; set; }
        public string StoreRoom { get; set; } = null!;
        public string Position { get; set; } = null!;
        public string ItemNum { get; set; } = null!;
        public decimal StockLevel { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public decimal Inactive { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal LastCount { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public string? SerialNum { get; set; }
        public string? VendorLot { get; set; }
        public string? Division { get; set; }
        public decimal LastPrice { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal FixPrice { get; set; }
        public string IssuePrice { get; set; } = null!;
        public string IssueMethod { get; set; } = null!;
        public string? CrAccount { get; set; }
        public string? DrAccount { get; set; }
        public string? VendorPart { get; set; }
        public decimal QuotedPrice { get; set; }
        public DateTime InStoreDate { get; set; }
        public string? IssueUnit { get; set; }
        public string? Category { get; set; }
        public decimal Serialized { get; set; }
        public decimal Markup { get; set; }
        public string? Equipment { get; set; }
    }
}

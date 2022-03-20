using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInvCountLine
    {
        public decimal? Posted { get; set; }
        public decimal? Counted { get; set; }
        public string BatchNum { get; set; } = null!;
        public decimal Counter { get; set; }
        public string ItemNum { get; set; } = null!;
        public string StoreRoom { get; set; } = null!;
        public string Position { get; set; } = null!;
        public decimal StockLevel { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public decimal LastCount { get; set; }
        public DateTime InStoreDate { get; set; }
        public string? ItemDesc { get; set; }
        public string? Category { get; set; }
        public string? IssueUnit { get; set; }
        public string? Vendor { get; set; }
        public string? Manufacturer { get; set; }
        public decimal Serialized { get; set; }
        public string? SubType0 { get; set; }
        public string? SubType1 { get; set; }
        public string? SubType2 { get; set; }
        public string? SubType3 { get; set; }
        public string? SubType4 { get; set; }
        public string? VendorPart { get; set; }
        public string? ManufPartNum { get; set; }
        public decimal Warranty { get; set; }
        public string IssuePrice { get; set; } = null!;
        public string IssueMethod { get; set; } = null!;
        public string PurchasePrice { get; set; } = null!;
        public decimal FixPrice { get; set; }
        public string? DrAccount { get; set; }
        public decimal MaxStock { get; set; }
        public decimal MinStock { get; set; }
        public string? ReorderMethod { get; set; }
        public string? Defvendor { get; set; }
        public string? CrAccount { get; set; }
        public string? Defmanufacturer { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal LastPrice { get; set; }
        public string Defposition { get; set; } = null!;
        public string? LotNum { get; set; }
        public string? Division { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VItemvendorlist
    {
        public string? ItemDesc { get; set; }
        public string? IssueUnit { get; set; }
        public string Vendor { get; set; } = null!;
        public string? VendorPart { get; set; }
        public string? PurchaseUnit { get; set; }
        public decimal LastPrice { get; set; }
        public decimal QuotedPrice { get; set; }
        public decimal Conversion { get; set; }
        public string ItemNum { get; set; } = null!;
        public decimal? IsDefault { get; set; }
        public decimal Serialized { get; set; }
        public string IssuePrice { get; set; } = null!;
        public string IssueMethod { get; set; } = null!;
        public string PurchasePrice { get; set; } = null!;
        public decimal Counter { get; set; }
        public decimal LookupCounter { get; set; }
    }
}

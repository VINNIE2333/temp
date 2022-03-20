using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class ItemVendor
    {
        public string ItemNum { get; set; } = null!;
        public string Vendor { get; set; } = null!;
        public string? VendorPart { get; set; }
        public string? PurchaseUnit { get; set; }
        public decimal Conversion { get; set; }
        public decimal LastPrice { get; set; }
        public decimal QuotedPrice { get; set; }
        public decimal Discount { get; set; }
        public string? Modifyby { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? Createdby { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal Dirtylog { get; set; }
        public decimal Counter { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal? IsDefault { get; set; }
    }
}

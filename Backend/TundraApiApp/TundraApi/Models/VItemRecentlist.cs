using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VItemRecentlist
    {
        public string? UserId { get; set; }
        public DateTime? AccessDate { get; set; }
        public string ItemNum { get; set; } = null!;
        public string? ItemDesc { get; set; }
        public string? Category { get; set; }
        public string? IssueUnit { get; set; }
        public string? Vendor { get; set; }
        public string? Manufacturer { get; set; }
        public decimal Inactive { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ShortDesc { get; set; }
        public decimal Serialized { get; set; }
        public decimal Markup { get; set; }
        public decimal Stocked { get; set; }
        public string? SubType0 { get; set; }
        public string? SubType1 { get; set; }
        public string? SubType2 { get; set; }
        public string? SubType3 { get; set; }
        public string? SubType4 { get; set; }
        public string? VendorPart { get; set; }
        public string? Division { get; set; }
        public string? ManufPartNum { get; set; }
        public decimal Warranty { get; set; }
        public string IssuePrice { get; set; } = null!;
        public string IssueMethod { get; set; } = null!;
        public string PurchasePrice { get; set; } = null!;
        public decimal FixPrice { get; set; }
        public string? Modifyby { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Creationdate { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal? Tax1Exempt { get; set; }
        public decimal? Tax2Exempt { get; set; }
    }
}

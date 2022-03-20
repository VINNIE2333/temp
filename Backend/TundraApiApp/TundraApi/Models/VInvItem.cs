using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInvItem
    {
        public string? ItemsCategory { get; set; }
        public string? ItemsChangeRemark { get; set; }
        public string? ItemsCreatedby { get; set; }
        public DateTime? ItemsCreationdate { get; set; }
        public decimal ItemsDirtyLog { get; set; }
        public string? ItemsDivision { get; set; }
        public decimal ItemsFixPrice { get; set; }
        public decimal ItemsInactive { get; set; }
        public string ItemsIssueMethod { get; set; } = null!;
        public string ItemsIssuePrice { get; set; } = null!;
        public string? ItemsIssueUnit { get; set; }
        public string? ItemsItemDesc { get; set; }
        public string ItemsItemNum { get; set; } = null!;
        public string? ItemsManufacturer { get; set; }
        public string? ItemsManufPartNum { get; set; }
        public decimal ItemsMarkup { get; set; }
        public string? ItemsModifyby { get; set; }
        public DateTime? ItemsModifyDate { get; set; }
        public string ItemsPurchasePrice { get; set; } = null!;
        public decimal ItemsSerialized { get; set; }
        public string? ItemsShortDesc { get; set; }
        public decimal ItemsStocked { get; set; }
        public string? ItemsSubType0 { get; set; }
        public string? ItemsSubType1 { get; set; }
        public string? ItemsSubType2 { get; set; }
        public string? ItemsSubType3 { get; set; }
        public string? ItemsSubType4 { get; set; }
        public string? ItemsVendor { get; set; }
        public string? ItemsVendorPart { get; set; }
        public decimal ItemsWarranty { get; set; }
        public string InactiveItem { get; set; } = null!;
        public string StockedItem { get; set; } = null!;
        public string SerializedItem { get; set; } = null!;
        public string? VendorVendName { get; set; }
        public string? ManufacturerMName { get; set; }
        public string? Printdate1 { get; set; }
        public string? Printdate2 { get; set; }
    }
}

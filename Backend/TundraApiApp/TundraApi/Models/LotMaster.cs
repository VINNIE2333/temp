using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class LotMaster
    {
        public string LotNum { get; set; } = null!;
        public string? ItemNum { get; set; }
        public string? ItemDesc { get; set; }
        public decimal Quantity { get; set; }
        public decimal VirtualQuantity { get; set; }
        public decimal Cost { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime ReceiveDate { get; set; }
        public string? Vendor { get; set; }
        public string? Manufacturer { get; set; }
        public decimal Inactive { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal Dirtylog { get; set; }
        public string? SerialNum { get; set; }
        public string? Equipment { get; set; }
        public string? VendorLot { get; set; }
        public string? Division { get; set; }
        public string? Storeroom { get; set; }
        public string LotType { get; set; } = null!;
        public string? ChangeRemark { get; set; }
    }
}

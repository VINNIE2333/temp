using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VendorService
    {
        public int Id { get; set; }
        public string? Vendor { get; set; }
        public string ServiceCode { get; set; } = null!;
        public string? Description { get; set; }
        public string? VendorPartNum { get; set; }
        public string? Unit { get; set; }
        public decimal LastPrice { get; set; }
        public decimal QuotedPrice { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

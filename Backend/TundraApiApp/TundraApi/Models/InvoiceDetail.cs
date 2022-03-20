using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class InvoiceDetail
    {
        public decimal Counter { get; set; }
        public string InvoiceNo { get; set; } = null!;
        public decimal? PolineCounter { get; set; }
        public decimal InvoiceQty { get; set; }
        public decimal LineAmount { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal Price { get; set; }
        public string? ItemNum { get; set; }
        public string? ItemDesc { get; set; }
    }
}

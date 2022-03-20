using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class InvoiceHeader
    {
        public string InvoiceNo { get; set; } = null!;
        public string? VendorInvoiceNo { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string Ponumber { get; set; } = null!;
        public decimal Cost { get; set; }
        public string? VendorCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal BaseCurrencyTotal { get; set; }
    }
}

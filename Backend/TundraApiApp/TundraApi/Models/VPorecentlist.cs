using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPorecentlist
    {
        public string PoNum { get; set; } = null!;
        public string? PoDesc { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public string? Status { get; set; }
        public decimal OpenPo { get; set; }
        public string? Vendor { get; set; }
        public decimal SubTotal { get; set; }
        public decimal Tax1Total { get; set; }
        public decimal Tax2Total { get; set; }
        public decimal PoTotal { get; set; }
        public decimal Freight { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public string? ShipTo { get; set; }
        public string? ShipAddress1 { get; set; }
        public string? ShipAddress2 { get; set; }
        public string? ShipAddress3 { get; set; }
        public string? BillTo { get; set; }
        public string? BillAddress1 { get; set; }
        public string? BillAddress2 { get; set; }
        public string? BillAddress3 { get; set; }
        public string? Terms { get; set; }
        public string? Po1 { get; set; }
        public string? Po2 { get; set; }
        public string? Po3 { get; set; }
        public string? Po4 { get; set; }
        public decimal Po9 { get; set; }
        public decimal Po10 { get; set; }
        public string? Division { get; set; }
        public string? Empid { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ShipPhone { get; set; }
        public string? BillPhone { get; set; }
        public string? Potype { get; set; }
        public DateTime? RequiredDate { get; set; }
        public DateTime? PromisedDate { get; set; }
        public string? VendorCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal BaseCurrencyTotal { get; set; }
        public string? ExchangeAccount { get; set; }
        public string? Department { get; set; }
        public string? Manager { get; set; }
        public string? Priority { get; set; }
        public decimal StatusCode { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? UserId { get; set; }
        public DateTime? AccessDate { get; set; }
        public string? TermsCode { get; set; }
        public string? Customer { get; set; }
    }
}

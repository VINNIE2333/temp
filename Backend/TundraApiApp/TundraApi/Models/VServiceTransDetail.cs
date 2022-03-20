using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VServiceTransDetail
    {
        public decimal Counter { get; set; }
        public string? ItemNum { get; set; }
        public string? ItemDesc { get; set; }
        public DateTime TransDate { get; set; }
        public string TransType { get; set; } = null!;
        public decimal IsService { get; set; }
        public decimal IsInventory { get; set; }
        public string? Vendor { get; set; }
        public string IssueUnit { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal AddCost { get; set; }
        public decimal TotalCost { get; set; }
        public string? IssueTo { get; set; }
        public string? ShipTo { get; set; }
        public DateTime? PostDate { get; set; }
        public string? BatchNum { get; set; }
        public string? Modifyby { get; set; }
        public DateTime? Modifydate { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Creationdate { get; set; }
        public decimal Dirtylog { get; set; }
        public decimal Inactive { get; set; }
        public string? VendorCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public string? PurchaseUnit { get; set; }
        public decimal Conversion { get; set; }
        public string? ChangeRemark { get; set; }
        public string? Wonum { get; set; }
        public string? Equipment { get; set; }
        public string? Location { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public string? Empid { get; set; }
        public decimal? ChargeBackAmount { get; set; }
        public decimal? Cbtax1 { get; set; }
        public decimal? Cbtax2 { get; set; }
        public string? ReqNum { get; set; }
        public decimal? ReqLineCounter { get; set; }
        public string? BatchTransType { get; set; }
        public decimal BaseCurrencyTotal { get; set; }
        public string? ReturnVendor { get; set; }
        public decimal? WolineCounter { get; set; }
        public string? ReceiptBatchNum { get; set; }
        public string? Ponum { get; set; }
        public decimal? PolineCounter { get; set; }
        public decimal? ChargeBack { get; set; }
        public string? Tax1Account { get; set; }
        public string? Tax2Account { get; set; }
        public string? TaskNum { get; set; }
    }
}

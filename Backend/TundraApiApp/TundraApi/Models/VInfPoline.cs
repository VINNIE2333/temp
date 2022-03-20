using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInfPoline
    {
        public int Counter { get; set; }
        public string? PoNum { get; set; }
        public decimal? LineNum { get; set; }
        public string? WoNum { get; set; }
        public decimal? WolineCounter { get; set; }
        public string? ItemNum { get; set; }
        public string? ItemDesc { get; set; }
        public decimal IsInventory { get; set; }
        public string? StoreRoom { get; set; }
        public string? DrAccount { get; set; }
        public string? Vendor { get; set; }
        public string OpenFlag { get; set; } = null!;
        public decimal OrderQty { get; set; }
        public decimal ReceiveQty { get; set; }
        public decimal ReturnQty { get; set; }
        public string? IssueUnit { get; set; }
        public string? PurchaseUnit { get; set; }
        public decimal Conversion { get; set; }
        public decimal Price { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal TotalCost { get; set; }
        public string? Operator { get; set; }
        public decimal Inactive { get; set; }
        public string? Division { get; set; }
        public string? ReqNum { get; set; }
        public decimal? ReqLineCounter { get; set; }
        public string? Empid { get; set; }
        public string? Equipment { get; set; }
        public string? Location { get; set; }
        public string? VendorCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal BaseCurrencyTotal { get; set; }
        public string? ExchangeAccount { get; set; }
        public string? VendorPart { get; set; }
        public decimal NewEquip { get; set; }
        public DateTime? PostDate { get; set; }
        public decimal IsService { get; set; }
        public string? Tax1Account { get; set; }
        public string? Tax2Account { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal? Serialized { get; set; }
        public string? CrAccount { get; set; }
        public string? BudgetType { get; set; }
        public string? Acct1 { get; set; }
        public string? Acct2 { get; set; }
        public string? Acct3 { get; set; }
    }
}

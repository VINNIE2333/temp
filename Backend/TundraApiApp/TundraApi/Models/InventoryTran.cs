using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class InventoryTran
    {
        public decimal Counter { get; set; }
        public decimal? LotCounter { get; set; }
        public string? StoreRoom { get; set; }
        public string? LotNum { get; set; }
        public string? Position { get; set; }
        public string? ItemNum { get; set; }
        public string? ItemDesc { get; set; }
        public DateTime TransDate { get; set; }
        public string TransType { get; set; } = null!;
        public decimal IsService { get; set; }
        public decimal IsInventory { get; set; }
        public string? Vendor { get; set; }
        public string? OtherStoreRoom { get; set; }
        public string IssueUnit { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal AddCost { get; set; }
        public decimal TotalCost { get; set; }
        public string? Ponum { get; set; }
        public decimal? PolineCounter { get; set; }
        public string? IssueTo { get; set; }
        public string? ShipTo { get; set; }
        public decimal ChargeBack { get; set; }
        public DateTime? PostDate { get; set; }
        public string? BatchNum { get; set; }
        public string? Modifyby { get; set; }
        public DateTime? Modifydate { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Creationdate { get; set; }
        public decimal Dirtylog { get; set; }
        public decimal Inactive { get; set; }
        public string? OtherPosition { get; set; }
        public string? OtherLotNum { get; set; }
        public decimal? OtherLotCounter { get; set; }
        public decimal StoreroomQty { get; set; }
        public string? VendorCurrency { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal BaseCurrencyTotal { get; set; }
        public string? PurchaseUnit { get; set; }
        public decimal Conversion { get; set; }
        public string? ChangeRemark { get; set; }
        public string? RepairShop { get; set; }
        public string? ReturnVendor { get; set; }
        public decimal? OtherTransCounter { get; set; }
        public string? ConditionCode { get; set; }
        public decimal Condition { get; set; }
        public string? Mtnum { get; set; }
        public string? Comment { get; set; }
    }
}

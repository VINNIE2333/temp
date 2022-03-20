using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInventoryTransBatch
    {
        public string? Wonum { get; set; }
        public string? Equipment { get; set; }
        public string? Location { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public string? Empid { get; set; }
        public string? ShipTo { get; set; }
        public decimal ChargeBackAmount { get; set; }
        public decimal Cbtax1 { get; set; }
        public decimal Cbtax2 { get; set; }
        public decimal Inactive { get; set; }
        public decimal Invoiced { get; set; }
        public decimal? PolineCounter { get; set; }
        public string? ReqNum { get; set; }
        public string? Ponum { get; set; }
        public decimal? ReqLineCounter { get; set; }
        public decimal Quantity { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal AddCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal UnitPrice { get; set; }
        public string BatchNum { get; set; } = null!;
        public string? Itemnum { get; set; }
        public string? Storeroom { get; set; }
        public string? ItemDesc { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public decimal? Dirtylog { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? IsInventory { get; set; }
        public decimal? IsService { get; set; }
        public string? TransType { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal MarkupAmount { get; set; }
        public decimal ChargeBack { get; set; }
        public string? IssueUnit { get; set; }
        public string? DocType { get; set; }
        public string? DocNumber { get; set; }
        public string? PurchaseUnit { get; set; }
        public decimal Staging { get; set; }
        public string? ReceiptBatchNum { get; set; }
        public decimal? WolineCounter { get; set; }
        public decimal? Conversion { get; set; }
        public string? EquipSerial { get; set; }
        public string? SerialNum { get; set; }
        public string? ReceiptLotNum { get; set; }
        public string? InvCountBatchNum { get; set; }
        public string? Vendor { get; set; }
        public string? Tax1Account { get; set; }
        public string? Tax2Account { get; set; }
        public string? TaskNum { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VRequestLine
    {
        public int Counter { get; set; }
        public string? ReqNum { get; set; }
        public decimal LineNum { get; set; }
        public string? Category { get; set; }
        public string? ItemNum { get; set; }
        public string? ItemDesc { get; set; }
        public decimal IsInventory { get; set; }
        public string? DrAccount { get; set; }
        public decimal StatusFlags { get; set; }
        public string? Status { get; set; }
        public decimal RequestQty { get; set; }
        public string? IssueUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal AddCost { get; set; }
        public decimal TotalCost { get; set; }
        public string? Employee { get; set; }
        public decimal Ipa { get; set; }
        public string? Operator { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Inactive { get; set; }
        public string? Division { get; set; }
        public decimal IsService { get; set; }
        public string? CrAccount { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal Dirtylog { get; set; }
        public decimal? Qtyonorder { get; set; }
        public decimal? Qtyreserved { get; set; }
        public decimal? Issuedqty { get; set; }
        public decimal? OrderedQty { get; set; }
    }
}

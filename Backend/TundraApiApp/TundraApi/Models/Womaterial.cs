using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Womaterial
    {
        public int Counter { get; set; }
        public string? ItemNum { get; set; }
        public string? Description { get; set; }
        public DateTime? TransDate { get; set; }
        public string? WoNum { get; set; }
        public string? Unit { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal AddCost { get; set; }
        public decimal Extension { get; set; }
        public string? Craccount { get; set; }
        public string? DrAccount { get; set; }
        public string? Vendor { get; set; }
        public string? Store { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Estimate { get; set; }
        public decimal? RefNum { get; set; }
        public decimal Inactive { get; set; }
        public decimal Actual { get; set; }
        public DateTime? PostDate { get; set; }
        public decimal PublicNote { get; set; }
        public decimal ChargeBack { get; set; }
        public string? TaskNum { get; set; }
        public string? EquipSerial { get; set; }
        public string? SerialNum { get; set; }
        public decimal ChargeBackAmount { get; set; }
        public decimal MarkupAmount { get; set; }
        public decimal Cbtax1 { get; set; }
        public decimal Cbtax2 { get; set; }
        public DateTime? PrintDate { get; set; }
        public string? PrintPerson { get; set; }
        public string? Tax1Account { get; set; }
        public string? Tax2Account { get; set; }
        public string? ModifyBy { get; set; }
        public decimal DirtyLog { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string OrderType { get; set; } = null!;
        public decimal Reserved { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

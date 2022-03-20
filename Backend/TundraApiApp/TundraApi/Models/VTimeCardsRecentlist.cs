using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VTimeCardsRecentlist
    {
        public decimal Counter { get; set; }
        public string? Empid { get; set; }
        public DateTime? TransDate { get; set; }
        public string? WoNum { get; set; }
        public string? Craft { get; set; }
        public string? Craccount { get; set; }
        public string? DrAccount { get; set; }
        public string? Description { get; set; }
        public string? TaskNum { get; set; }
        public string? LaborType { get; set; }
        public decimal Scale { get; set; }
        public decimal Hours { get; set; }
        public decimal Rate { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal AddCost { get; set; }
        public decimal TotalCost { get; set; }
        public decimal ChargeBack { get; set; }
        public decimal MarkupAmount { get; set; }
        public decimal Cbtax1 { get; set; }
        public decimal Cbtax2 { get; set; }
        public decimal ChargeBackAmount { get; set; }
        public decimal Estimate { get; set; }
        public decimal Inactive { get; set; }
        public decimal Actual { get; set; }
        public decimal? RefNum { get; set; }
        public string? Remark { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? PrintDate { get; set; }
        public string? PrintPerson { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Ordertype { get; set; } = null!;
        public string? ChangeRemark { get; set; }
        public string? UserId { get; set; }
        public DateTime? AccessDate { get; set; }
    }
}

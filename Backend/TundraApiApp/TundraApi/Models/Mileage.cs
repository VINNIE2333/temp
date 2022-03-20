using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Mileage
    {
        public decimal Counter { get; set; }
        public DateTime? TransDate { get; set; }
        public string? Empid { get; set; }
        public string? Description { get; set; }
        public string WoNum { get; set; } = null!;
        public string FromAddress { get; set; } = null!;
        public string ToAddress { get; set; } = null!;
        public string? FromLocation { get; set; }
        public string? ToLocation { get; set; }
        public decimal Distance { get; set; }
        public string? Unit { get; set; }
        public decimal Rate { get; set; }
        public decimal RoundTrip { get; set; }
        public decimal AddCost { get; set; }
        public decimal Tax1 { get; set; }
        public decimal Tax2 { get; set; }
        public decimal TotalCost { get; set; }
        public decimal? LabourCounter { get; set; }
        public decimal DirtyLog { get; set; }
        public decimal Inactive { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public string OrderType { get; set; } = null!;
        public decimal ChargeBack { get; set; }
        public decimal MarkupAmount { get; set; }
        public decimal Cbtax1 { get; set; }
        public decimal Cbtax2 { get; set; }
        public decimal ChargeBackAmount { get; set; }
        public decimal Estimate { get; set; }
        public decimal Actual { get; set; }
        public string? TaskNum { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

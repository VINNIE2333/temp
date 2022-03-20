using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class InvMain
    {
        public string ItemNum { get; set; } = null!;
        public string StoreRoom { get; set; } = null!;
        public string? DrAccount { get; set; }
        public decimal MaxStock { get; set; }
        public decimal MinStock { get; set; }
        public string? ReorderMethod { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public decimal Inactive { get; set; }
        public int Counter { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public string? Defvendor { get; set; }
        public string? CrAccount { get; set; }
        public string? Defmanufacturer { get; set; }
        public decimal AvgPrice { get; set; }
        public decimal LastPrice { get; set; }
        public string Defposition { get; set; } = null!;
    }
}

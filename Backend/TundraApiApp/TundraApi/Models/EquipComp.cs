using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class EquipComp
    {
        public decimal Counter { get; set; }
        public string Equipment { get; set; } = null!;
        public string ItemNum { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Quantity { get; set; }
        public decimal IsInventory { get; set; }
        public string? IssueUnit { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

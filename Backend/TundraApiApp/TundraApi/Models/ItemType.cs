using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class ItemType
    {
        public decimal Counter { get; set; }
        public string ItemLevel { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Inactive { get; set; }
        public string? ParentCode { get; set; }
        public string? ChangeRemark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Dirtylog { get; set; }
    }
}

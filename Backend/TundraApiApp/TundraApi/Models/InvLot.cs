using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class InvLot
    {
        public decimal Counter { get; set; }
        public string? LotNum { get; set; }
        public string ItemNum { get; set; } = null!;
        public string StoreRoom { get; set; } = null!;
        public string Position { get; set; } = null!;
        public decimal StockLevel { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public decimal Inactive { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal LastCount { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public DateTime InStoreDate { get; set; }
        public string? LastLotNum { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

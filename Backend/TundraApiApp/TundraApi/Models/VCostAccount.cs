using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VCostAccount
    {
        public int Counter { get; set; }
        public string? LinkType { get; set; }
        public string? LinkId { get; set; }
        public string? Account { get; set; }
        public decimal Keeppercent { get; set; }
        public decimal? CostPercent { get; set; }
        public decimal? CostAmount { get; set; }
        public decimal? CostPercentInBaseTable { get; set; }
        public decimal? CostAmountInBaseTable { get; set; }
        public decimal? TotalCost { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

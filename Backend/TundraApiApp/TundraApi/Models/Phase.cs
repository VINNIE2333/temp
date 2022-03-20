using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Phase
    {
        public int Counter { get; set; }
        public string Phase1 { get; set; } = null!;
        public string ProjectId { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Percentage { get; set; }
        public decimal Budget { get; set; }
        public decimal? PhaseOrder { get; set; }
        public decimal Inactive { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

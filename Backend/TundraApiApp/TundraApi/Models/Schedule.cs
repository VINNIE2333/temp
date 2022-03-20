using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Schedule
    {
        public decimal Counter { get; set; }
        public DateTime? TransDate { get; set; }
        public string? ResourceId { get; set; }
        public string? ResourceType { get; set; }
        public string? ActivityId { get; set; }
        public string? ActivityType { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? RecurrenceRule { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal? DirtyLog { get; set; }
    }
}

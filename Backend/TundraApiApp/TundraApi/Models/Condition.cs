using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Condition
    {
        public decimal Counter { get; set; }
        public string ConditionCode { get; set; } = null!;
        public decimal ConditionValue { get; set; }
        public string? ConditionDescription { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
    }
}

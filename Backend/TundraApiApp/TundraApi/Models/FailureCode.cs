using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class FailureCode
    {
        public int Counter { get; set; }
        public string FailureCode1 { get; set; } = null!;
        public decimal FailureLevel { get; set; }
        public string Description { get; set; } = null!;
        public string? ParentCode { get; set; }
        public decimal Inactive { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

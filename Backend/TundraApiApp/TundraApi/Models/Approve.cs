using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Approve
    {
        public int Counter { get; set; }
        public string Module { get; set; } = null!;
        public decimal Amount { get; set; }
        public decimal ApproveInOrder { get; set; }
        public decimal OnePersonApprove { get; set; }
        public string ApproveCode { get; set; } = null!;
        public decimal RequiredNumber { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
    }
}

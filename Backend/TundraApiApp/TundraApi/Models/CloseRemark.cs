using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class CloseRemark
    {
        public string CloseRemCode { get; set; } = null!;
        public string? CloseRemText { get; set; }
        public string? CloseRemShortText { get; set; }
        public decimal Inactive { get; set; }
        public string? RemarkType { get; set; }
        public decimal DirtyLog { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

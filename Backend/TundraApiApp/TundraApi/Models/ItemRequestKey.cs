using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class ItemRequestKey
    {
        public int Counter { get; set; }
        public string? ReqNum { get; set; }
        public string? Location { get; set; }
        public decimal ExteriaDoor { get; set; }
        public decimal InteriaDoor { get; set; }
        public string? Remarks { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

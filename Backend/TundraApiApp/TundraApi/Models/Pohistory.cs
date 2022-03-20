using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Pohistory
    {
        public int Counter { get; set; }
        public string? PoNum { get; set; }
        public DateTime? TransDate { get; set; }
        public string? Status { get; set; }
        public string? Operator { get; set; }
        public string? Remark { get; set; }
        public decimal? Statuscode { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
    }
}

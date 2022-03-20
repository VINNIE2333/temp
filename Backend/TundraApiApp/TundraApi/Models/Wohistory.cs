using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Wohistory
    {
        public decimal Counter { get; set; }
        public string? WoNum { get; set; }
        public DateTime? TransDate { get; set; }
        public string? Status { get; set; }
        public decimal? StatusCode { get; set; }
        public string? Remark { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
    }
}

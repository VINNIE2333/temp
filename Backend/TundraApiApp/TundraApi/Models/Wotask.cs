using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Wotask
    {
        public decimal Counter { get; set; }
        public string? WoNum { get; set; }
        public string? TaskNum { get; set; }
        public string? TaskDesc { get; set; }
        public string? TaskMemo { get; set; }
        public string? CrAccount { get; set; }
        public string? DrAccount { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Estimate { get; set; }
        public decimal? RefNum { get; set; }
        public decimal Actual { get; set; }
        public decimal PublicNote { get; set; }
        public decimal TaskHours { get; set; }
        public string? Unit { get; set; }
        public decimal UnitCost { get; set; }
        public decimal TotalCost { get; set; }
        public string? Modifyby { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Creationdate { get; set; }
        public decimal DirtyLog { get; set; }
        public string Ordertype { get; set; } = null!;
        public string? ChangeRemark { get; set; }
    }
}

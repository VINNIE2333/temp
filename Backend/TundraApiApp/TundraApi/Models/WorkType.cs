using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class WorkType
    {
        public string Wotype { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal System { get; set; }
        public decimal Inactive { get; set; }
        public decimal Rate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal DirtyLog { get; set; }
        public int Counter { get; set; }
    }
}

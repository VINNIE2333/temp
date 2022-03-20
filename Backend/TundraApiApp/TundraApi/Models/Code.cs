using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Code
    {
        public string Tfield { get; set; } = null!;
        public string Tcode { get; set; } = null!;
        public string? Tdesc { get; set; }
        public decimal Inactive { get; set; }
        public decimal System { get; set; }
        public string? Tcode1 { get; set; }
        public string? Tcode2 { get; set; }
        public decimal Counter { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

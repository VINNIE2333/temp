using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Craft
    {
        public string Craft1 { get; set; } = null!;
        public string? CraftDesc { get; set; }
        public decimal Rate { get; set; }
        public decimal Inactive { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

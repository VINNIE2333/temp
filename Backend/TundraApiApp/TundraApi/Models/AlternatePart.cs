using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class AlternatePart
    {
        public decimal Counter { get; set; }
        public string ItemNum { get; set; } = null!;
        public string AlternateItemNum { get; set; } = null!;
        public decimal DirtyLog { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

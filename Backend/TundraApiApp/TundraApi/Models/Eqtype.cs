using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Eqtype
    {
        public decimal Counter { get; set; }
        public string Eqlevel { get; set; } = null!;
        public string Eqcode { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Inactive { get; set; }
        public string? ParentCode { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

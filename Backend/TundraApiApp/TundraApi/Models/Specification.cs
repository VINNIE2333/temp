using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Specification
    {
        public string LinkType { get; set; } = null!;
        public string LinkId { get; set; } = null!;
        public string SpecTag { get; set; } = null!;
        public string? SpecValue { get; set; }
        public string? MeasUnit { get; set; }
        public decimal Counter { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? CreatedBy { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal IsTemplate { get; set; }
        public decimal OrderBy { get; set; }
        public decimal AddToLongDescription { get; set; }
        public decimal AddToShortDescription { get; set; }
    }
}

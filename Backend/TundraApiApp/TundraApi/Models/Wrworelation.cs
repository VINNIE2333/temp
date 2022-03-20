using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Wrworelation
    {
        public decimal Counter { get; set; }
        public string Wrnum { get; set; } = null!;
        public string Wonum { get; set; } = null!;
        public string AssignedBy { get; set; } = null!;
        public DateTime? AssignDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Dirtylog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

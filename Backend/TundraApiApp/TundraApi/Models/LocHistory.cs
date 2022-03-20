using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class LocHistory
    {
        public int Counter { get; set; }
        public string? Location { get; set; }
        public DateTime? TransDate { get; set; }
        public string? StatusOld { get; set; }
        public string? StatusNew { get; set; }
        public string? ParentOld { get; set; }
        public string? ParentNew { get; set; }
        public string? DivisionOld { get; set; }
        public string? DivisionNew { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Eqhistory
    {
        public int Counter { get; set; }
        public string? Equipment { get; set; }
        public DateTime? TransDate { get; set; }
        public string? StatusOld { get; set; }
        public string? StatusNew { get; set; }
        public string? OperatorOld { get; set; }
        public string? OperatorNew { get; set; }
        public string? LocationOld { get; set; }
        public string? LocationNew { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ModifyBy { get; set; }
        public string? ParentOld { get; set; }
        public string? ParentNew { get; set; }
        public string? DivisionOld { get; set; }
        public string? DivisionNew { get; set; }
        public string? AccountOld { get; set; }
        public string? AccountNew { get; set; }
    }
}

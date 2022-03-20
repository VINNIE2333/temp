using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VProjectcost
    {
        public string Title { get; set; } = null!;
        public string Idnum { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Costs { get; set; }
        public string? Phase { get; set; }
        public string? Projectid { get; set; }
        public string? Id { get; set; }
        public string Title2 { get; set; } = null!;
        public string Seq { get; set; } = null!;
        public string? Manager { get; set; }
        public string? Prjtype { get; set; }
        public decimal? Costs2 { get; set; }
        public string? ManagerName { get; set; }
    }
}

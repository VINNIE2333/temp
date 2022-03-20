using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class RouteDetail
    {
        public decimal Counter { get; set; }
        public string RouteName { get; set; } = null!;
        public string LinkId { get; set; } = null!;
        public string ReadingType { get; set; } = null!;
        public string SpecTag { get; set; } = null!;
        public decimal? TagOrder { get; set; }
        public decimal? IdOrder { get; set; }
        public string? ChangeRemark { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string LinkType { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VRoutePrint
    {
        public string RouteName { get; set; } = null!;
        public string? RouteDesc { get; set; }
        public string? Division { get; set; }
        public decimal Inactive { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal DirtyLog { get; set; }
        public DateTime Printdate { get; set; }
    }
}

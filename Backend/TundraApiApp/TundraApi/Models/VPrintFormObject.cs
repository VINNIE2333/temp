using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPrintFormObject
    {
        public decimal? Mastercounter { get; set; }
        public string? ControlId { get; set; }
        public string? ControlType { get; set; }
        public string? DbTable { get; set; }
        public string? DbField { get; set; }
        public string? SubType { get; set; }
        public decimal? Counter { get; set; }
        public string? ControlName { get; set; }
    }
}

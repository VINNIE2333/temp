using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class SpecificationHistory
    {
        public string? LinkType { get; set; }
        public string? LinkId { get; set; }
        public string? SpecTag { get; set; }
        public string? SpecValue { get; set; }
        public string? MeasUnit { get; set; }
        public decimal IsTemplate { get; set; }
        public decimal? IdOrder { get; set; }
        public decimal? TagOrder { get; set; }
        public string? Template { get; set; }
        public int Counter { get; set; }
        public decimal MeterType { get; set; }
        public decimal? Rollover { get; set; }
        public decimal? AvgReading { get; set; }
        public decimal? AvgInterval { get; set; }
        public decimal FudgeFactor { get; set; }
        public decimal Cumulative { get; set; }
    }
}

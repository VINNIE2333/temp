using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VAllMaxReading
    {
        public string? Equipment { get; set; }
        public string? MeterName { get; set; }
        public string? Unit { get; set; }
        public decimal? CurrentReading { get; set; }
        public DateTime? MeterDate { get; set; }
        public decimal? MaxOffset { get; set; }
        public decimal? MaxReading { get; set; }
        public string? MeterType { get; set; }
        public int Counter { get; set; }
        public decimal PrimaryMeter { get; set; }
        public decimal ResetMeter { get; set; }
        public decimal? AvgInterval { get; set; }
        public decimal FudgeFactor { get; set; }
        public decimal? AvgReading { get; set; }
        public decimal? Rollover { get; set; }
        public decimal Cumulative { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

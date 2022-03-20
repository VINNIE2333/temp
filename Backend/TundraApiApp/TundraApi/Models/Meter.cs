using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Meter
    {
        public int Counter { get; set; }
        public string? Equipment { get; set; }
        public string? MeterName { get; set; }
        public string? Unit { get; set; }
        public decimal PrimaryMeter { get; set; }
        public string? Template { get; set; }
        public decimal ResetMeter { get; set; }
        public decimal? Rollover { get; set; }
        public decimal? AvgReading { get; set; }
        public decimal? AvgInterval { get; set; }
        public decimal FudgeFactor { get; set; }
        public decimal Cumulative { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? CreatedBy { get; set; }
        public decimal DirtyLog { get; set; }
        public string? MeterType { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

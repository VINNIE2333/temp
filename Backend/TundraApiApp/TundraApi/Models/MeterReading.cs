using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class MeterReading
    {
        public decimal Counter { get; set; }
        public string? Equipment { get; set; }
        public decimal MeterReading1 { get; set; }
        public DateTime? MeterDate { get; set; }
        public string? Operator { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? MeterName { get; set; }
        public decimal MeterOffset { get; set; }
        public string? WoNum { get; set; }
        public decimal? MIncrement { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? Comment { get; set; }
        public string? RouteName { get; set; }
    }
}

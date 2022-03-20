using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VEqLastMeterReading
    {
        public string? MeterName { get; set; }
        public string? Equipment { get; set; }
        public decimal MeterReading { get; set; }
        public DateTime? MeterDate { get; set; }
        public string? Unit { get; set; }
    }
}

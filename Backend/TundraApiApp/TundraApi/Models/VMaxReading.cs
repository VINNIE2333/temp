using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VMaxReading
    {
        public string? Equipment { get; set; }
        public string? MeterName { get; set; }
        public decimal? MaxReading { get; set; }
        public decimal? MaxOffset { get; set; }
    }
}

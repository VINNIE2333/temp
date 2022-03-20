using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VMaxReadingDateBack
    {
        public string? Equipment { get; set; }
        public string? MeterName { get; set; }
        public decimal? MaxReading { get; set; }
        public decimal? MaxOffset { get; set; }
        public DateTime? MeterDate { get; set; }
        public decimal? CurrentReading { get; set; }
    }
}

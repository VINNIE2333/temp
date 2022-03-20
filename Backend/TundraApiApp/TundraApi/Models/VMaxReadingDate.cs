using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VMaxReadingDate
    {
        public string? Equipment { get; set; }
        public string? MeterName { get; set; }
        public decimal? MaxReading { get; set; }
        public decimal MaxOffSet { get; set; }
        public decimal CurrentReading { get; set; }
        public DateTime? MeterDate { get; set; }
    }
}

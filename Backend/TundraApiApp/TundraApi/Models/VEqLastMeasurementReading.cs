using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VEqLastMeasurementReading
    {
        public string? MeasurementName { get; set; }
        public string? LinkType { get; set; }
        public string? LinkId { get; set; }
        public string MeasureReading { get; set; } = null!;
        public DateTime MeasureDate { get; set; }
        public string? MeasUnit { get; set; }
    }
}

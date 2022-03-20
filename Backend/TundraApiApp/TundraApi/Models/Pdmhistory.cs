using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Pdmhistory
    {
        public decimal Counter { get; set; }
        public string Pdmnum { get; set; } = null!;
        public string MeasurementReading { get; set; } = null!;
        public DateTime TransDate { get; set; }
        public string ActionTriggered { get; set; } = null!;
        public string? Wonum { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

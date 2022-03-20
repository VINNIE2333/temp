using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VLastMeasurementReading
    {
        public string? LinkType { get; set; }
        public string? LinkId { get; set; }
        public string? MeasurementName { get; set; }
        public string MeasureReading { get; set; } = null!;
        public DateTime MeasureDate { get; set; }
        public string? EmpId { get; set; }
        public decimal Counter { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? CreatedBy { get; set; }
        public decimal Dirtylog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

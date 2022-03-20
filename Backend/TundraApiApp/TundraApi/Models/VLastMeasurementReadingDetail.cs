using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VLastMeasurementReadingDetail
    {
        public string? LinkType { get; set; }
        public string? LinkId { get; set; }
        public string? MeasurementName { get; set; }
        public string? MeasUnit { get; set; }
        public string? ValueType { get; set; }
        public int Counter { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? MeasureReading { get; set; }
    }
}

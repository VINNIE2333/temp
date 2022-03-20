using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class LabourTimeStamp
    {
        public int Counter { get; set; }
        public int Batchnum { get; set; }
        public string Wonum { get; set; } = null!;
        public string Empid { get; set; } = null!;
        public DateTime Starttime { get; set; }
        public string Labtype { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? Endtime { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class LaborType
    {
        public string LabType { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Scale { get; set; }
        public decimal Inactive { get; set; }
        public decimal System { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

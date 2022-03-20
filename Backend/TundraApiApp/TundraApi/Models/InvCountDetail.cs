using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class InvCountDetail
    {
        public decimal Counter { get; set; }
        public string BatchNum { get; set; } = null!;
        public decimal? CountTime { get; set; }
        public decimal LotCounter { get; set; }
        public decimal Count { get; set; }
        public string Operator { get; set; } = null!;
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal Posted { get; set; }
        public decimal Inactive { get; set; }
        public string? Comment { get; set; }
    }
}

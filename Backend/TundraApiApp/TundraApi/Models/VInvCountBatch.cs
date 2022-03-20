using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInvCountBatch
    {
        public string BatchNum { get; set; } = null!;
        public string Storeroom { get; set; } = null!;
        public string? ModifyBy { get; set; }
        public string? Createdby { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal RequiredMatches { get; set; }
        public string? Division { get; set; }
        public string? Description { get; set; }
        public decimal? QueryId { get; set; }
        public string? Queryname { get; set; }
        public string Status { get; set; } = null!;
        public decimal Inactive { get; set; }
        public decimal DirtyLog { get; set; }
    }
}

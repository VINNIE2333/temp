using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Term
    {
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public decimal DefaultCode { get; set; }
        public string CodeType { get; set; } = null!;
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal Dirtylog { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}

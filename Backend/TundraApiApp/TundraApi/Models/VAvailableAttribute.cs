using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VAvailableAttribute
    {
        public string? ReadingType { get; set; }
        public string? Attribute { get; set; }
        public string? Unit { get; set; }
        public string? LinkType { get; set; }
        public string LinkId { get; set; } = null!;
        public string? Description { get; set; }
        public string? ParentId { get; set; }
        public string? ParentDesc { get; set; }
        public string? Location { get; set; }
        public string? LocationDesc { get; set; }
        public string? Status { get; set; }
        public string? Type { get; set; }
        public string? Priority { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public decimal Inactive { get; set; }
        public string? Division { get; set; }
        public string? Department { get; set; }
        public decimal MasterRec { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
    }
}

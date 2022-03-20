using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Link
    {
        public decimal Counter { get; set; }
        public string? LinkTitle { get; set; }
        public string? LinkUrl { get; set; }
        public string? Description { get; set; }
        public string? Wwmodule { get; set; }
        public string? Wwrecord { get; set; }
        public string? LinkType { get; set; }
        public string? Division { get; set; }
        public string? DocId { get; set; }
        public string? Subfolder { get; set; }
        public string? ChangeRemark { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VRouteReading
    {
        public string LinkType { get; set; } = null!;
        public string LinkId { get; set; } = null!;
        public string? Description { get; set; }
        public string? ParentId { get; set; }
        public string? ParentDesc { get; set; }
        public string? Location { get; set; }
        public string? LocationDesc { get; set; }
        public string? Status { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public string? Type { get; set; }
        public string? Priority { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public decimal Inactive { get; set; }
        public string? Division { get; set; }
        public decimal DirtyLog { get; set; }
        public string? Department { get; set; }
        public decimal MasterRec { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? ChangeRemark { get; set; }
        public string RouteName { get; set; } = null!;
        public string Readingtype { get; set; } = null!;
        public string Spectag { get; set; } = null!;
        public decimal? Tagorder { get; set; }
        public decimal? Idorder { get; set; }
        public decimal Counter { get; set; }
        public string? LastReading { get; set; }
        public decimal? LastOffSet { get; set; }
        public DateTime? LastReadingDate { get; set; }
        public string? NewReading { get; set; }
        public DateTime? NewDate { get; set; }
        public string? Comment { get; set; }
        public string? Valuetype { get; set; }
        public string? Unit { get; set; }
        public string? CurrentReading { get; set; }
    }
}

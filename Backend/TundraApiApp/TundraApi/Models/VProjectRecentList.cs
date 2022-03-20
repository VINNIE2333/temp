using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VProjectRecentList
    {
        public string ProjectId { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Manager { get; set; }
        public string? Status { get; set; }
        public string? Department { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal? DirtyLog { get; set; }
        public string? Division { get; set; }
        public decimal Inactive { get; set; }
        public string? PrjType { get; set; }
        public decimal Prj9 { get; set; }
        public decimal Prj10 { get; set; }
        public DateTime? CloseDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? StatusCode { get; set; }
        public string? UserId { get; set; }
        public DateTime? AccessDate { get; set; }
        public string? Customer { get; set; }
        public string? Prj1 { get; set; }
        public string? Prj2 { get; set; }
        public string? Prj3 { get; set; }
        public string? Prj4 { get; set; }
        public string? Prj5 { get; set; }
        public decimal? Prj6 { get; set; }
        public decimal? Prj7 { get; set; }
        public decimal? Prj8 { get; set; }
    }
}

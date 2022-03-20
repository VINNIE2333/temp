using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInterfaceRecentList
    {
        public string InterfaceName { get; set; } = null!;
        public string? InterfaceType { get; set; }
        public string? FileType { get; set; }
        public string? Delimiter { get; set; }
        public string? FileLocation { get; set; }
        public decimal ExcludePosted { get; set; }
        public decimal UpdatePosted { get; set; }
        public decimal AppendData { get; set; }
        public decimal UpdateData { get; set; }
        public string? UserModule { get; set; }
        public decimal? RunInterval { get; set; }
        public DateTime? LastRun { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public DateTime? AccessDate { get; set; }
        public string? UserId { get; set; }
        public string? TriggerField { get; set; }
        public string? TriggerMode { get; set; }
        public string? ActionTable { get; set; }
        public decimal Inactive { get; set; }
        public string? ServiceUrl { get; set; }
        public string? Dbaction { get; set; }
        public string? RemoteUsername { get; set; }
        public string? RemotePassword { get; set; }
    }
}

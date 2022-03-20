using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VProceduresDetail
    {
        public string ProcNum { get; set; } = null!;
        public string? Priority { get; set; }
        public decimal? Duration { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public string? Requester { get; set; }
        public string? Contact { get; set; }
        public string? ContactPhone { get; set; }
        public decimal EstHours { get; set; }
        public decimal EstLabor { get; set; }
        public decimal EstMaterial { get; set; }
        public decimal EstTools { get; set; }
        public string? Department { get; set; }
        public string? Manager { get; set; }
        public string? Craft { get; set; }
        public string? Employee { get; set; }
        public string? Crew { get; set; }
        public string? Location { get; set; }
        public string? LocationDesc { get; set; }
        public string? Equipment { get; set; }
        public string? EquipmentDesc { get; set; }
        public string? Room { get; set; }
        public string? Request { get; set; }
        public string? Operator { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Inactive { get; set; }
        public string? Pr1 { get; set; }
        public string? Pr2 { get; set; }
        public string? Pr3 { get; set; }
        public string? Pr4 { get; set; }
        public string? Division { get; set; }
        public decimal DirtyLog { get; set; }
        public decimal MasterRec { get; set; }
        public decimal EstService { get; set; }
        public decimal Cbcode { get; set; }
        public string? ClientCode { get; set; }
        public string? Modifyby { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? WosubType { get; set; }
        public string? SurfLsd { get; set; }
        public string? SurfSect { get; set; }
        public string? SurfTownShip { get; set; }
        public string? SurfRange { get; set; }
        public string? Dhlsd { get; set; }
        public string? Dhsect { get; set; }
        public string? DhtownShip { get; set; }
        public string? Dhrange { get; set; }
    }
}

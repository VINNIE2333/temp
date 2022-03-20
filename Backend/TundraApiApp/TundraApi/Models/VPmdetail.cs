using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPmdetail
    {
        public string PmNum { get; set; } = null!;
        public string? Equipment { get; set; }
        public string? EquipmentDesc { get; set; }
        public string? Location { get; set; }
        public string? LocationDesc { get; set; }
        public string? Room { get; set; }
        public string? ProcNum { get; set; }
        public string? IntervalUnit { get; set; }
        public decimal? Pminterval { get; set; }
        public decimal? LastPmreading { get; set; }
        public decimal? NextPmreading { get; set; }
        public decimal? AvgUsage { get; set; }
        public decimal? MeterRange { get; set; }
        public DateTime? NextDueDate { get; set; }
        public DateTime? LastPmdate { get; set; }
        public DateTime? LastIssueDate { get; set; }
        public DateTime? OverrideDate { get; set; }
        public DateTime? PmgenDate { get; set; }
        public decimal OnDue { get; set; }
        public string? Priority { get; set; }
        public decimal? Duration { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public decimal EstHours { get; set; }
        public decimal EstLabor { get; set; }
        public decimal EstMaterial { get; set; }
        public decimal EstTools { get; set; }
        public string? Department { get; set; }
        public string? Manager { get; set; }
        public string? Craft { get; set; }
        public string? Employee { get; set; }
        public string? Crew { get; set; }
        public string? Request { get; set; }
        public string? Operator { get; set; }
        public string? LastWoNum { get; set; }
        public decimal OpenWo { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Inactive { get; set; }
        public string? Pm1 { get; set; }
        public string? Pm2 { get; set; }
        public int? Pm3 { get; set; }
        public int? Pm4 { get; set; }
        public string? Division { get; set; }
        public decimal DirtyLog { get; set; }
        public string? Wostatus { get; set; }
        public string? MeterName { get; set; }
        public decimal NestedPm { get; set; }
        public string? WoType { get; set; }
        public decimal? MeterInterval { get; set; }
        public string? MeterName2 { get; set; }
        public decimal? LastPmreading2 { get; set; }
        public decimal? NextPmreading2 { get; set; }
        public decimal? MeterRange2 { get; set; }
        public decimal? MeterInterval2 { get; set; }
        public decimal Cbcode { get; set; }
        public string? ClientCode { get; set; }
        public decimal EstService { get; set; }
        public decimal IsLocked { get; set; }
        public string? Contact { get; set; }
        public string? ContactPhone { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? RouteName { get; set; }
        public string? Requester { get; set; }
        public string? WosubType { get; set; }
        public string? SurfLsd { get; set; }
        public string? SurfRange { get; set; }
        public string? SurfSect { get; set; }
        public string? SurfTownShip { get; set; }
        public string? Dhlsd { get; set; }
        public string? Dhsect { get; set; }
        public string? Dhrange { get; set; }
        public string? DhtownShip { get; set; }
        public string? SerialNum { get; set; }
        public string? Manufacturer { get; set; }
        public string? AssetTag { get; set; }
    }
}

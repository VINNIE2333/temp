using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Pdm
    {
        public string Pdmnum { get; set; } = null!;
        public string? Equipment { get; set; }
        public string? EquipmentDesc { get; set; }
        public string? Location { get; set; }
        public string? LocationDesc { get; set; }
        public string? Room { get; set; }
        public string? HighLimitProc { get; set; }
        public string? HighWarningProc { get; set; }
        public string? LowWarningProc { get; set; }
        public string? LowLimitProc { get; set; }
        public string? Priority { get; set; }
        public decimal? Duration { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
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
        public decimal? HighLimit { get; set; }
        public decimal? HighWarning { get; set; }
        public decimal? LowLimit { get; set; }
        public decimal? LowWarning { get; set; }
        public string? Division { get; set; }
        public decimal DirtyLog { get; set; }
        public string? Wostatus { get; set; }
        public string? MeasurementName { get; set; }
        public string? WoType { get; set; }
        public decimal Cbcode { get; set; }
        public string? ClientCode { get; set; }
        public string? Contact { get; set; }
        public string? ContactPhone { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? Pdm1 { get; set; }
        public string? Pdm2 { get; set; }
        public string? Pdm3 { get; set; }
        public string? Pdm4 { get; set; }
        public string? Pdm5 { get; set; }
        public decimal? Pdm6 { get; set; }
        public decimal? Pdm7 { get; set; }
        public decimal? Pdm8 { get; set; }
        public decimal? Pdm9 { get; set; }
        public decimal? Pdm10 { get; set; }
        public string? HighLimitEmail { get; set; }
        public string? LowLimitEmail { get; set; }
        public string? HighWarningEmail { get; set; }
        public string? LowWarningEmail { get; set; }
        public string? Customer { get; set; }
    }
}

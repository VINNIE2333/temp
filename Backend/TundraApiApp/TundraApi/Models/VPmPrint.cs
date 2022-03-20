using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPmPrint
    {
        public decimal? PmAvgUsage { get; set; }
        public decimal PmCbcode { get; set; }
        public string? PmClientCode { get; set; }
        public string? PmContact { get; set; }
        public string? PmContactPhone { get; set; }
        public string? PmCrAccount { get; set; }
        public string? PmCraft { get; set; }
        public string? PmCrew { get; set; }
        public string? PmDepartment { get; set; }
        public string? PmDivision { get; set; }
        public string? PmDrAccount { get; set; }
        public decimal? PmDuration { get; set; }
        public string? PmEmployee { get; set; }
        public string? PmEquipment { get; set; }
        public string? PmEquipmentDesc { get; set; }
        public decimal PmEstHours { get; set; }
        public decimal PmEstLabor { get; set; }
        public decimal PmEstMaterial { get; set; }
        public decimal PmEstService { get; set; }
        public decimal PmEstTools { get; set; }
        public decimal PmInactive { get; set; }
        public string? PmIntervalUnit { get; set; }
        public decimal PmIsLocked { get; set; }
        public DateTime? PmLastIssueDate { get; set; }
        public DateTime? PmLastPmdate { get; set; }
        public decimal? PmLastPmreading { get; set; }
        public decimal? PmLastPmreading2 { get; set; }
        public string? PmLocation { get; set; }
        public string? PmLocationDesc { get; set; }
        public string? PmManager { get; set; }
        public decimal? PmMeterInterval { get; set; }
        public decimal? PmMeterInterval2 { get; set; }
        public string? PmMeterName { get; set; }
        public string? PmMeterName2 { get; set; }
        public decimal? PmMeterRange { get; set; }
        public decimal? PmMeterRange2 { get; set; }
        public decimal PmNestedPm { get; set; }
        public DateTime? PmNextDueDate { get; set; }
        public decimal? PmNextPmreading { get; set; }
        public decimal? PmNextPmreading2 { get; set; }
        public DateTime? PmOverrideDate { get; set; }
        public DateTime? PmPmgenDate { get; set; }
        public decimal? PmPminterval { get; set; }
        public string PmPmNum { get; set; } = null!;
        public string? PmPriority { get; set; }
        public string? PmProcnum { get; set; }
        public string? PmRequest { get; set; }
        public string? PmRoom { get; set; }
        public string? PmRouteName { get; set; }
        public string? PmWostatus { get; set; }
        public string? PmWoType { get; set; }
        public string? EquipmentSerialNum { get; set; }
        public string? Printdate { get; set; }
        public DateTime Printdate2 { get; set; }
        public string? LocationSurfLsd { get; set; }
        public string? LocationSurfSect { get; set; }
        public string? LocationSurfTownShip { get; set; }
        public string? LocationSurfRange { get; set; }
        public string? LocationDhlsd { get; set; }
        public string? LocationDhsect { get; set; }
        public string? LocationDhtownShip { get; set; }
        public string? LocationDhrange { get; set; }
        public string? AssetTag { get; set; }
        public string? Manufacturer { get; set; }
        public string? PmCustomer { get; set; }
        public decimal PmEstMileage { get; set; }
    }
}

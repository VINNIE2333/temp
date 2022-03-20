using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPdm
    {
        public decimal PdmCbcode { get; set; }
        public string? PdmChangeRemark { get; set; }
        public string? PdmClientCode { get; set; }
        public string? PdmContact { get; set; }
        public string? PdmContactPhone { get; set; }
        public string? PdmCrAccount { get; set; }
        public string? PdmCraft { get; set; }
        public string? PdmCreatedBy { get; set; }
        public DateTime? PdmCreationDate { get; set; }
        public string? PdmCrew { get; set; }
        public string? PdmDepartment { get; set; }
        public decimal PdmDirtyLog { get; set; }
        public string? PdmDivision { get; set; }
        public string? PdmDrAccount { get; set; }
        public decimal? PdmDuration { get; set; }
        public string? PdmEmployee { get; set; }
        public string? PdmEquipment { get; set; }
        public string? PdmEquipmentDesc { get; set; }
        public decimal? PdmHighLimit { get; set; }
        public string? PdmHighLimitProc { get; set; }
        public decimal? PdmHighWarning { get; set; }
        public string? PdmHighWarningProc { get; set; }
        public decimal PdmInactive { get; set; }
        public string? PdmLastWoNum { get; set; }
        public string? PdmLocation { get; set; }
        public string? PdmLocationDesc { get; set; }
        public decimal? PdmLowLimit { get; set; }
        public string? PdmLowLimitProc { get; set; }
        public decimal? PdmLowWarning { get; set; }
        public string? PdmLowWarningProc { get; set; }
        public string? PdmManager { get; set; }
        public string? PdmMeasurementName { get; set; }
        public string? PdmModifyBy { get; set; }
        public DateTime? PdmModifyDate { get; set; }
        public decimal PdmOpenWo { get; set; }
        public string? PdmOperator { get; set; }
        public string PdmPdmnum { get; set; } = null!;
        public string? PdmPriority { get; set; }
        public string? PdmRequest { get; set; }
        public string? PdmRoom { get; set; }
        public string? PdmWostatus { get; set; }
        public string? PdmWoType { get; set; }
        public string? MeasurementMeasUnit { get; set; }
        public string? EquipmentSerialNum { get; set; }
        public DateTime Printdate2 { get; set; }
        public string? Printdate { get; set; }
        public string? PdmCustomer { get; set; }
    }
}

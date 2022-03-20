using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPdmemailnotification
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
        public string? PdmHighLimitEmail { get; set; }
        public string? PdmHighLimitProc { get; set; }
        public decimal? PdmHighWarning { get; set; }
        public string? PdmHighWarningEmail { get; set; }
        public string? PdmHighWarningProc { get; set; }
        public decimal PdmInactive { get; set; }
        public string? PdmLastWoNum { get; set; }
        public string? PdmLocation { get; set; }
        public string? PdmLocationDesc { get; set; }
        public decimal? PdmLowLimit { get; set; }
        public string? PdmLowLimitEmail { get; set; }
        public string? PdmLowLimitProc { get; set; }
        public decimal? PdmLowWarning { get; set; }
        public string? PdmLowWarningEmail { get; set; }
        public string? PdmLowWarningProc { get; set; }
        public string? PdmManager { get; set; }
        public string? PdmMeasurementName { get; set; }
        public string? PdmModifyBy { get; set; }
        public DateTime? PdmModifyDate { get; set; }
        public decimal PdmOpenWo { get; set; }
        public string? PdmOperator { get; set; }
        public string? PdmPdm1 { get; set; }
        public decimal? PdmPdm10 { get; set; }
        public string? PdmPdm2 { get; set; }
        public string? PdmPdm3 { get; set; }
        public string? PdmPdm4 { get; set; }
        public string? PdmPdm5 { get; set; }
        public decimal? PdmPdm6 { get; set; }
        public decimal? PdmPdm7 { get; set; }
        public decimal? PdmPdm8 { get; set; }
        public decimal? PdmPdm9 { get; set; }
        public string PdmPdmnum { get; set; } = null!;
        public string? PdmPriority { get; set; }
        public string? PdmRequest { get; set; }
        public string? PdmRoom { get; set; }
        public string? PdmWostatus { get; set; }
        public string? PdmWoType { get; set; }
        public string PdmhistoryActionTriggered { get; set; } = null!;
        public decimal PdmhistoryCounter { get; set; }
        public string PdmhistoryMeasurementReading { get; set; } = null!;
        public string PdmhistoryPdmnum { get; set; } = null!;
        public DateTime PdmhistoryTransDate { get; set; }
        public string? PdmhistoryWonum { get; set; }
        public string? EquipmentAddress1 { get; set; }
        public string? EquipmentAddress2 { get; set; }
        public string? EquipmentAssetTag { get; set; }
        public decimal? EquipmentCbcode { get; set; }
        public string? EquipmentClientCode { get; set; }
        public decimal? EquipmentCostToDate { get; set; }
        public string? EquipmentCrAccount { get; set; }
        public string? EquipmentDepartment { get; set; }
        public decimal? EquipmentDeprecFactor { get; set; }
        public decimal? EquipmentDeprecMethod { get; set; }
        public string? EquipmentDivision { get; set; }
        public decimal? EquipmentDownTime { get; set; }
        public string? EquipmentDrAccount { get; set; }
        public string? EquipmentEquipment { get; set; }
        public string? EquipmentEquipmentDesc { get; set; }
        public decimal? EquipmentHazardous { get; set; }
        public decimal? EquipmentInactive { get; set; }
        public string? EquipmentInstructions { get; set; }
        public string? EquipmentItemNum { get; set; }
        public string? EquipmentLocation { get; set; }
        public string? EquipmentLocationDesc { get; set; }
        public string? EquipmentManufacturer { get; set; }
        public decimal? EquipmentMasterRec { get; set; }
        public decimal? EquipmentMeterReading { get; set; }
        public string? EquipmentMrtype { get; set; }
        public string? EquipmentNote1 { get; set; }
        public decimal? EquipmentNote10 { get; set; }
        public string? EquipmentNote2 { get; set; }
        public string? EquipmentNote3 { get; set; }
        public string? EquipmentNote4 { get; set; }
        public string? EquipmentNote5 { get; set; }
        public decimal? EquipmentNote6 { get; set; }
        public decimal? EquipmentNote7 { get; set; }
        public decimal? EquipmentNote8 { get; set; }
        public decimal? EquipmentNote9 { get; set; }
        public string? EquipmentOperator { get; set; }
        public string? EquipmentParentDesc { get; set; }
        public string? EquipmentParentId { get; set; }
        public string? EquipmentPriority { get; set; }
        public DateTime? EquipmentPurchaseDate { get; set; }
        public decimal? EquipmentPurchasePrice { get; set; }
        public decimal? EquipmentRate { get; set; }
        public string? EquipmentRoom { get; set; }
        public decimal? EquipmentSalvageValue { get; set; }
        public string? EquipmentSerialNum { get; set; }
        public string? EquipmentStatus { get; set; }
        public string? EquipmentSubType1 { get; set; }
        public string? EquipmentSubType2 { get; set; }
        public string? EquipmentSubType3 { get; set; }
        public string? EquipmentSubType4 { get; set; }
        public string? EquipmentSubType5 { get; set; }
        public decimal? EquipmentUsefulLife { get; set; }
        public string? EquipmentVendor { get; set; }
        public DateTime? EquipmentWarrantyDate { get; set; }
        public string? MeasurementMeasUnit { get; set; }
        public string? MeasurementLinkType { get; set; }
        public DateTime? PdmhistoryCreationDate { get; set; }
    }
}

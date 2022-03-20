using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VEquipmentPrint
    {
        public string? EquipmentAddress1 { get; set; }
        public string? EquipmentAddress2 { get; set; }
        public string? EquipmentAssetTag { get; set; }
        public decimal EquipmentCbcode { get; set; }
        public string? EquipmentClientCode { get; set; }
        public decimal EquipmentCostToDate { get; set; }
        public string? EquipmentCrAccount { get; set; }
        public string? EquipmentDepartment { get; set; }
        public decimal? EquipmentDeprecFactor { get; set; }
        public decimal? EquipmentDeprecMethod { get; set; }
        public decimal EquipmentDirtylog { get; set; }
        public string? EquipmentDivision { get; set; }
        public decimal EquipmentDownTime { get; set; }
        public string? EquipmentDrAccount { get; set; }
        public string EquipmentEquipment { get; set; } = null!;
        public string? EquipmentEquipmentDesc { get; set; }
        public decimal EquipmentHazardous { get; set; }
        public decimal EquipmentInactive { get; set; }
        public string? EquipmentInstructions { get; set; }
        public string? EquipmentItemNum { get; set; }
        public string? EquipmentLocation { get; set; }
        public string? EquipmentLocationDesc { get; set; }
        public string? EquipmentManufacturer { get; set; }
        public decimal EquipmentMasterRec { get; set; }
        public decimal? EquipmentMeterReading { get; set; }
        public DateTime? EquipmentModifyDate { get; set; }
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
        public decimal EquipmentPurchasePrice { get; set; }
        public decimal EquipmentRate { get; set; }
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
        public string? ManufacturerMName { get; set; }
        public string? VendorVendName { get; set; }
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
        public decimal CurrentValue { get; set; }
        public string? EquipmentCustomer { get; set; }
    }
}

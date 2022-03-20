using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class UpdateScreenFieldAttr
    {
        public string Equipment { get; set; } = null!;
        public string? EquipmentDesc { get; set; }
        public string? ParentId { get; set; }
        public string? ParentDesc { get; set; }
        public string? Location { get; set; }
        public string? LocationDesc { get; set; }
        public string? Room { get; set; }
        public string? Status { get; set; }
        public string? Operator { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? WarrantyDate { get; set; }
        public decimal CostToDate { get; set; }
        public string? Mrtype { get; set; }
        public string? Priority { get; set; }
        public decimal DownTime { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public string? Vendor { get; set; }
        public string? Manufacturer { get; set; }
        public string? SerialNum { get; set; }
        public string? AssetTag { get; set; }
        public string? SubType1 { get; set; }
        public string? SubType2 { get; set; }
        public string? SubType3 { get; set; }
        public string? SubType4 { get; set; }
        public string? SubType5 { get; set; }
        public decimal? MeterReading { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Inactive { get; set; }
        public string? Note1 { get; set; }
        public string? Note2 { get; set; }
        public string? Note3 { get; set; }
        public string? Note4 { get; set; }
        public string? Note5 { get; set; }
        public decimal? Note6 { get; set; }
        public decimal? Note7 { get; set; }
        public decimal? Note8 { get; set; }
        public decimal? Note9 { get; set; }
        public decimal? Note10 { get; set; }
        public string? Division { get; set; }
        public decimal DirtyLog { get; set; }
        public string? Instructions { get; set; }
        public decimal? AvgReading { get; set; }
        public decimal? AvgInterval { get; set; }
        public string? Department { get; set; }
        public string? ItemNum { get; set; }
        public decimal? SalvageValue { get; set; }
        public decimal? UsefulLife { get; set; }
        public decimal? DeprecMethod { get; set; }
        public decimal? DeprecFactor { get; set; }
        public decimal Rate { get; set; }
        public DateTime? PostDate { get; set; }
        public decimal MasterRec { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public decimal Cbcode { get; set; }
        public string? ClientCode { get; set; }
        public decimal Hazardous { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal MobileEquipment { get; set; }
        public string? ChangeRemark { get; set; }
        public string? SurfLsd { get; set; }
        public string? SurfRange { get; set; }
        public string? SurfSect { get; set; }
        public string? SurfTownShip { get; set; }
        public string? Dhlsd { get; set; }
        public string? Dhsect { get; set; }
        public string? Dhrange { get; set; }
        public string? DhtownShip { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VEquipmentdowntime1
    {
        public string? WorkOrderRequest { get; set; }
        public string? WorkOrderWoType { get; set; }
        public decimal EquipmentDownTime { get; set; }
        public string EquipmentEquipment { get; set; } = null!;
        public string? EquipmentEquipmentDesc { get; set; }
        public string? WorkOrderRequest0 { get; set; }
        public string WorkOrderWoNum { get; set; } = null!;
        public string? WorkOrderWoType0 { get; set; }
        public decimal EquipmentDownTime0 { get; set; }
        public string EquipmentEquipment0 { get; set; } = null!;
        public string? EquipmentEquipmentDesc0 { get; set; }
        public decimal? CalField { get; set; }
        public string? WorkOrderLocation { get; set; }
        public string? WorkOrderLocationDesc { get; set; }
        public string? WorkOrderDrAccount { get; set; }
        public string? WorkOrderLocation0 { get; set; }
        public string? WorkOrderLocationDesc0 { get; set; }
        public decimal WorkOrderActHours { get; set; }
        public decimal WorkOrderActHours0 { get; set; }
        public decimal WorkOrderActLabor { get; set; }
        public decimal WorkOrderActMaterial { get; set; }
        public decimal WorkOrderActService { get; set; }
    }
}

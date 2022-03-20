using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VWoandequip
    {
        public string WorkOrderWoNum { get; set; } = null!;
        public string EquipmentEquipment { get; set; } = null!;
        public string? EquipmentLocation { get; set; }
        public string? EquipmentSerialNum { get; set; }
        public string? EquipmentStatus { get; set; }
        public string? WorkOrderEquipment { get; set; }
        public string? WorkOrderEquipmentDesc { get; set; }
        public string? WorkOrderRequest { get; set; }
        public string? WorkOrderWoType { get; set; }
        public decimal ActLabor { get; set; }
        public decimal? Cost { get; set; }
    }
}

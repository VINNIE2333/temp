using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VWohistory
    {
        public string WorkOrderWoNum { get; set; } = null!;
        public string? WohistoryRemark { get; set; }
        public decimal WohistoryCounter { get; set; }
        public string? WohistoryCreatedBy { get; set; }
        public DateTime? WohistoryCreationDate { get; set; }
        public string? WorkOrderStatus { get; set; }
        public string? WorkOrderWoSubType { get; set; }
    }
}

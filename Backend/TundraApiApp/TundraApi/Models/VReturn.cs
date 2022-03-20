using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VReturn
    {
        public string IssueType { get; set; } = null!;
        public string? Number { get; set; }
        public string BatchNum { get; set; } = null!;
        public DateTime? TransDate { get; set; }
        public string? ItemNum { get; set; }
        public string? Storeroom { get; set; }
        public decimal Quantity { get; set; }
        public int? ReturnQty { get; set; }
        public string IssueMethod { get; set; } = null!;
        public string? EquipSerial { get; set; }
        public string? SerialNum { get; set; }
        public string? TransType { get; set; }
        public decimal Serialized { get; set; }
        public string? ReturnStoreRoom { get; set; }
        public string? ReturnPosition { get; set; }
        public string? Location { get; set; }
    }
}

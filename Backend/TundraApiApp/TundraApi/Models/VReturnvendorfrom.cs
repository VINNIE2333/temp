using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VReturnvendorfrom
    {
        public decimal? Issuedqty { get; set; }
        public string? Lotnum { get; set; }
        public decimal? Lotcounter { get; set; }
        public string? ReturnFrom { get; set; }
        public decimal? LineCounter { get; set; }
        public string ReturnType { get; set; } = null!;
        public string? Batchnum { get; set; }
        public string? Vendorlot { get; set; }
        public string? Equipserial { get; set; }
        public string? Serialnum { get; set; }
        public string? ItemNum { get; set; }
        public decimal? TransCounter { get; set; }
        public decimal IsInventory { get; set; }
        public decimal? IsService { get; set; }
        public string? Division { get; set; }
        public string? Receiptbatchnum { get; set; }
        public DateTime? TransDate { get; set; }
    }
}

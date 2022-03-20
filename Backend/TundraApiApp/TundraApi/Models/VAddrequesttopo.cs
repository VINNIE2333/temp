using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VAddrequesttopo
    {
        public decimal IsService { get; set; }
        public string ReqType { get; set; } = null!;
        public int Counter { get; set; }
        public string? ItemNum { get; set; }
        public string? Description { get; set; }
        public string? Wonum { get; set; }
        public string? Unit { get; set; }
        public decimal Quantity { get; set; }
        public string? Storeroom { get; set; }
        public string? Request { get; set; }
        public DateTime? OpenDate { get; set; }
        public string? Department { get; set; }
        public string? Wotype { get; set; }
        public string? Priority { get; set; }
        public string? Division { get; set; }
        public decimal? QtyOnOrder { get; set; }
        public decimal? QtyReserved { get; set; }
        public decimal? IssuedQty { get; set; }
        public string? Vendor { get; set; }
        public decimal? OrderedQty { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VEmployeeVendor
    {
        public string Empid { get; set; } = null!;
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public decimal Rate { get; set; }
        public string? Phone { get; set; }
        public string? Craft { get; set; }
        public string? Email { get; set; }
        public string? Manager { get; set; }
        public decimal? Tax1 { get; set; }
        public decimal? Tax2 { get; set; }
        public string SelType { get; set; } = null!;
        public string? Division { get; set; }
    }
}

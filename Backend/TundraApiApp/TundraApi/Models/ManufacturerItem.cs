using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class ManufacturerItem
    {
        public string Manufacturer { get; set; } = null!;
        public string ItemNum { get; set; } = null!;
        public string? ManufPartNum { get; set; }
        public string? ChangeRemark { get; set; }
        public int Counter { get; set; }
    }
}

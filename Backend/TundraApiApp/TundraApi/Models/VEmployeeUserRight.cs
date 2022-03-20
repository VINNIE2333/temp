using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VEmployeeUserRight
    {
        public string Empid { get; set; } = null!;
        public string? EmpName { get; set; }
        public string? Craft { get; set; }
        public string? EmpGroup { get; set; }
        public string? EmpTitle { get; set; }
        public string? Manager { get; set; }
    }
}

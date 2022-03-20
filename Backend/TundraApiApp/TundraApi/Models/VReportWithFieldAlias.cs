using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VReportWithFieldAlias
    {
        public int Counter { get; set; }
        public string Reportname { get; set; } = null!;
        public string? Tablelist { get; set; }
        public string? Aliaslist { get; set; }
        public string? Reportowner { get; set; }
        public string? Reportmodule { get; set; }
        public decimal IsSystem { get; set; }
        public string? Sqltext { get; set; }
        public string? Reportdesc { get; set; }
        public string? Modifyby { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Modifydate { get; set; }
        public DateTime? Creationdate { get; set; }
        public decimal Dirtylog { get; set; }
        public string? Division { get; set; }
        public decimal DirectSql { get; set; }
        public decimal? Divisiontype { get; set; }
        public string? Charttype { get; set; }
        public decimal Printsql { get; set; }
        public decimal Printowner { get; set; }
        public decimal? Availableto { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal DefaultListReport { get; set; }
    }
}

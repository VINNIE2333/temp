using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VViewlist
    {
        public string ViewName { get; set; } = null!;
        public string TableName { get; set; } = null!;
        public string? Queryname { get; set; }
        public string? Tablelist { get; set; }
        public string? Aliaslist { get; set; }
        public string? Queryowner { get; set; }
        public string? Querymodule { get; set; }
        public decimal? IsSystem { get; set; }
        public string? Sqltext { get; set; }
        public string? Querydesc { get; set; }
        public string? Modifyby { get; set; }
        public string? Createdby { get; set; }
        public DateTime? Modifydate { get; set; }
        public DateTime? Creationdate { get; set; }
        public decimal? Dirtylog { get; set; }
        public decimal? Published { get; set; }
        public string? Publishedby { get; set; }
        public DateTime? Publishdate { get; set; }
        public decimal? DirectSql { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

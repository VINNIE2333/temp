using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInfTableDetailed
    {
        public decimal Counter { get; set; }
        public string InterfaceName { get; set; } = null!;
        public string InterfaceModule { get; set; } = null!;
        public string InterfaceType { get; set; } = null!;
        public string? SourceTable { get; set; }
        public string? TagName { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? Parenttable { get; set; }
        public string? Parenttablekeyfield { get; set; }
        public string? Tablefkfield { get; set; }
        public decimal? Exportrestriction { get; set; }
        public string? KeyFieldToTrigger { get; set; }
        public decimal Importtype { get; set; }
        public string IsUsed { get; set; } = null!;
        public string? ExportPrimaryKey { get; set; }
    }
}

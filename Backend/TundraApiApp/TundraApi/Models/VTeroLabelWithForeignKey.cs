using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VTeroLabelWithForeignKey
    {
        public decimal Id { get; set; }
        public string WwtableName { get; set; } = null!;
        public string WwfieldName { get; set; } = null!;
        public string? WwfieldType { get; set; }
        public decimal? WwfieldOrder { get; set; }
        public string? WwfieldDesc { get; set; }
        public string? WwfieldLabel { get; set; }
        public string? WwselectList { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public decimal? DecimalPlaces { get; set; }
        public decimal? MaxLength { get; set; }
        public string HistoryTag { get; set; } = null!;
        public string? ChangeRemark { get; set; }
        public decimal EmailFlag { get; set; }
        public decimal ExportFlag { get; set; }
        public string? Definition { get; set; }
        public string? SystemHelp { get; set; }
        public string? Lookuptable { get; set; }
        public string? Fieldlist { get; set; }
        public string? Extrafilter { get; set; }
        public string? Lookuplink { get; set; }
    }
}

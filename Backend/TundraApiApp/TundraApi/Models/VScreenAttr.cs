using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VScreenAttr
    {
        public string? ControlId { get; set; }
        public string? Subtype { get; set; }
        public decimal Colspan { get; set; }
        public decimal Rowspan { get; set; }
        public decimal ColumnPosition { get; set; }
        public decimal RowPosition { get; set; }
        public decimal Mandatory { get; set; }
        public decimal Systemmandatory { get; set; }
        public decimal Systemlookup { get; set; }
        public string? LookupLink { get; set; }
        public string? LookupTableName { get; set; }
        public decimal? Labeldisplay { get; set; }
        public int Counter { get; set; }
        public string? FileName { get; set; }
        public string? OldControlId { get; set; }
        public int Dcounter { get; set; }
        public decimal? LeftPos { get; set; }
        public decimal? TopPos { get; set; }
        public decimal? Swidth { get; set; }
        public decimal? Sheight { get; set; }
        public string? Empid { get; set; }
        public string? Groupid { get; set; }
        public int ScreenWidth { get; set; }
        public int ScreenHeight { get; set; }
        public int Smcounter { get; set; }
        public string? DefaultLabel { get; set; }
        public string? DbTable { get; set; }
        public string? DbField { get; set; }
        public string? AddNewField { get; set; }
        public string? AutoCompleteList { get; set; }
        public string? DesignTimeFilter { get; set; }
        public string? RunTimeFilter { get; set; }
        public string? FieldList { get; set; }
        public string? Placeholder { get; set; }
        public string? LookupPrimaryKey { get; set; }
        public string? OnchangeFilter { get; set; }
        public decimal? TabIndex { get; set; }
        public decimal? Fontsize { get; set; }
        public decimal? ReportLink { get; set; }
        public string? ClassName { get; set; }
    }
}

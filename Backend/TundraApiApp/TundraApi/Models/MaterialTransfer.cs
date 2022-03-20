using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class MaterialTransfer
    {
        public string Mtnum { get; set; } = null!;
        public string MtslipNum { get; set; } = null!;
        public string ProdPeriod { get; set; } = null!;
        public string? FromLocation { get; set; }
        public string? ToLocation { get; set; }
        public string? SourceCoding { get; set; }
        public string? DestinationCoding { get; set; }
        public string? Comment { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Dirtylog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

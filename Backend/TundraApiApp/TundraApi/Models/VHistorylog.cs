using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VHistorylog
    {
        public string? HistoryLogAction { get; set; }
        public decimal? HistoryLogBatchNum { get; set; }
        public decimal HistoryLogCounter { get; set; }
        public string? HistoryLogDbUser { get; set; }
        public string? HistoryLogFieldName { get; set; }
        public string? HistoryLogFieldValue { get; set; }
        public string? HistoryLogLinkId { get; set; }
        public string? HistoryLogLinkTable { get; set; }
        public string? HistoryLogModifyBy { get; set; }
        public DateTime? HistoryLogModifyDate { get; set; }
        public string? HistoryLogNewFieldValue { get; set; }
        public string? HistoryLogRemark { get; set; }
    }
}

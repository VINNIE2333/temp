using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Budget
    {
        public int Counter { get; set; }
        public decimal? BudgetType { get; set; }
        public DateTime? FiscalStartDate { get; set; }
        public DateTime? FiscalEndDate { get; set; }
        public decimal? FiscalYear { get; set; }
        public decimal BudgetAmount { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VProjectReport
    {
        public string? ProjectsDepartment { get; set; }
        public string? ProjectsDescription { get; set; }
        public string? ProjectsDivision { get; set; }
        public DateTime? ProjectsEndDate { get; set; }
        public string? ProjectsManager { get; set; }
        public DateTime? ProjectsModifyDate { get; set; }
        public DateTime? ProjectsOpenDate { get; set; }
        public string? ProjectsPrjType { get; set; }
        public string ProjectsProjectId { get; set; } = null!;
        public DateTime? ProjectsStartDate { get; set; }
        public string? ProjectsStatus { get; set; }
        public decimal? PhaseBudget { get; set; }
        public string? PhaseDescription { get; set; }
        public DateTime? PhaseEndDate { get; set; }
        public decimal? PhasePercentage { get; set; }
        public string? PhasePhase { get; set; }
        public decimal? PhasePhaseOrder { get; set; }
        public DateTime? PhaseStartDate { get; set; }
        public string? Printdate { get; set; }
        public string? ProjectsCustomer { get; set; }
    }
}

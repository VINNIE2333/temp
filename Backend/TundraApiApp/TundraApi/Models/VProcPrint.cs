using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VProcPrint
    {
        public decimal ProceduresCbcode { get; set; }
        public string? ProceduresClientCode { get; set; }
        public string? ProceduresContact { get; set; }
        public string? ProceduresContactPhone { get; set; }
        public string? ProceduresCrAccount { get; set; }
        public string? ProceduresCraft { get; set; }
        public string? ProceduresCrew { get; set; }
        public string? ProceduresDepartment { get; set; }
        public string? ProceduresDivision { get; set; }
        public string? ProceduresDrAccount { get; set; }
        public decimal? ProceduresDuration { get; set; }
        public string? ProceduresEmployee { get; set; }
        public string? ProceduresEquipment { get; set; }
        public string? ProceduresEquipmentDesc { get; set; }
        public decimal ProceduresEstHours { get; set; }
        public decimal ProceduresEstLabor { get; set; }
        public decimal ProceduresEstMaterial { get; set; }
        public decimal ProceduresEstService { get; set; }
        public decimal ProceduresEstTools { get; set; }
        public string? ProceduresLocation { get; set; }
        public string? ProceduresLocationDesc { get; set; }
        public string? ProceduresManager { get; set; }
        public decimal ProceduresMasterRec { get; set; }
        public string? ProceduresPriority { get; set; }
        public string ProceduresProcnum { get; set; } = null!;
        public string? ProceduresRequest { get; set; }
        public string? ProceduresRequester { get; set; }
        public string? ProceduresRoom { get; set; }
        public string? EquipmentSerialNum { get; set; }
        public string? Printdate { get; set; }
        public DateTime Printdate2 { get; set; }
        public string? LocationSurfLsd { get; set; }
        public string? LocationSurfSect { get; set; }
        public string? LocationSurfTownShip { get; set; }
        public string? LocationSurfRange { get; set; }
        public string? LocationDhlsd { get; set; }
        public string? LocationDhsect { get; set; }
        public string? LocationDhtownShip { get; set; }
        public string? LocationDhrange { get; set; }
        public string? Customer { get; set; }
    }
}

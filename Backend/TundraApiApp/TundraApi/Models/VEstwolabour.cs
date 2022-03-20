using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VEstwolabour
    {
        public decimal WorkOrderActHours { get; set; }
        public decimal WorkOrderActLabor { get; set; }
        public decimal WorkOrderActMaterial { get; set; }
        public decimal WorkOrderActService { get; set; }
        public decimal WorkOrderActTools { get; set; }
        public decimal WorkOrderAssignedHours { get; set; }
        public decimal WorkOrderChargeback { get; set; }
        public string? WorkOrderClientCode { get; set; }
        public string? WorkOrderCompCode { get; set; }
        public DateTime? WorkOrderCompDate { get; set; }
        public string? WorkOrderCompRemark { get; set; }
        public string? WorkOrderContact { get; set; }
        public string? WorkOrderContactPhone { get; set; }
        public string? WorkOrderCrAccount { get; set; }
        public string? WorkOrderCraft { get; set; }
        public string? WorkOrderCreatedBy { get; set; }
        public DateTime? WorkOrderCreationDate { get; set; }
        public string? WorkOrderCrew { get; set; }
        public string? WorkOrderDepartment { get; set; }
        public decimal WorkOrderDirtyLog { get; set; }
        public string? WorkOrderDivision { get; set; }
        public decimal WorkOrderDowntime { get; set; }
        public string? WorkOrderDrAccount { get; set; }
        public decimal? WorkOrderDuration { get; set; }
        public string? WorkOrderEmployee { get; set; }
        public string? WorkOrderEqaddress1 { get; set; }
        public string? WorkOrderEqaddress2 { get; set; }
        public string? WorkOrderEqoperator { get; set; }
        public string? WorkOrderEquipment { get; set; }
        public string? WorkOrderEquipmentDesc { get; set; }
        public decimal WorkOrderEstCost { get; set; }
        public decimal WorkOrderEstHours { get; set; }
        public decimal WorkOrderEstLabor { get; set; }
        public decimal WorkOrderEstMaterial { get; set; }
        public decimal WorkOrderEstService { get; set; }
        public decimal WorkOrderEstTools { get; set; }
        public string? WorkOrderFailureCode1 { get; set; }
        public string? WorkOrderFailureCode2 { get; set; }
        public string? WorkOrderFailureCode3 { get; set; }
        public string? WorkOrderLocation { get; set; }
        public string? WorkOrderLocationDesc { get; set; }
        public string? WorkOrderManager { get; set; }
        public string? WorkOrderModifyBy { get; set; }
        public DateTime? WorkOrderModifyDate { get; set; }
        public string? WorkOrderNote1 { get; set; }
        public string? WorkOrderNote2 { get; set; }
        public string? WorkOrderNote3 { get; set; }
        public string? WorkOrderNote4 { get; set; }
        public string? WorkOrderNote5 { get; set; }
        public string? WorkOrderNote6 { get; set; }
        public string? WorkOrderNote7 { get; set; }
        public string? WorkOrderNote8 { get; set; }
        public DateTime? WorkOrderOpenDate { get; set; }
        public string? WorkOrderPdmnum { get; set; }
        public string? WorkOrderPhase { get; set; }
        public string? WorkOrderPmNum { get; set; }
        public DateTime? WorkOrderPostDate { get; set; }
        public string? WorkOrderPriority { get; set; }
        public string? WorkOrderProcNum { get; set; }
        public string? WorkOrderProjectId { get; set; }
        public string? WorkOrderRequest { get; set; }
        public string? WorkOrderRequester { get; set; }
        public string? WorkOrderRoom { get; set; }
        public string? WorkOrderRouteName { get; set; }
        public string? WorkOrderStatus { get; set; }
        public decimal? WorkOrderStatusCode { get; set; }
        public DateTime? WorkOrderTargetDate { get; set; }
        public DateTime? WorkOrderTargetEndDate { get; set; }
        public string WorkOrderWoNum { get; set; } = null!;
        public string? WorkOrderWoType { get; set; }
        public string? WolabourDescription { get; set; }
        public string? WolabourEmpid { get; set; }
        public decimal WolabourHours { get; set; }
        public decimal WolabourEstimate { get; set; }
        public string WolabourOrderType { get; set; } = null!;
    }
}

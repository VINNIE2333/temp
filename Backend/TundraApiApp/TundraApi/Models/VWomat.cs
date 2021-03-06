using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VWomat
    {
        public decimal WorkOrderActHours { get; set; }
        public decimal WorkOrderActLabor { get; set; }
        public decimal WorkOrderActMaterial { get; set; }
        public decimal WorkOrderActMileage { get; set; }
        public decimal WorkOrderActService { get; set; }
        public decimal WorkOrderActTools { get; set; }
        public string? WorkOrderAlertType { get; set; }
        public decimal WorkOrderAssignedHours { get; set; }
        public string? WorkOrderChangeRemark { get; set; }
        public decimal WorkOrderChargeback { get; set; }
        public string? WorkOrderClientCode { get; set; }
        public string? WorkOrderCompCode { get; set; }
        public DateTime? WorkOrderCompDate { get; set; }
        public string? WorkOrderCompRemark { get; set; }
        public string? WorkOrderCompShortDesc { get; set; }
        public string? WorkOrderContact { get; set; }
        public string? WorkOrderContactPhone { get; set; }
        public string? WorkOrderCrAccount { get; set; }
        public string? WorkOrderCraft { get; set; }
        public string? WorkOrderCreatedBy { get; set; }
        public DateTime? WorkOrderCreationDate { get; set; }
        public string? WorkOrderCrew { get; set; }
        public string? WorkOrderCustomer { get; set; }
        public string? WorkOrderDepartment { get; set; }
        public string? WorkOrderDhlsd { get; set; }
        public string? WorkOrderDhrange { get; set; }
        public string? WorkOrderDhsect { get; set; }
        public string? WorkOrderDhtownShip { get; set; }
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
        public decimal WorkOrderEstMileage { get; set; }
        public decimal WorkOrderEstService { get; set; }
        public decimal WorkOrderEstTools { get; set; }
        public string? WorkOrderFailureCode1 { get; set; }
        public string? WorkOrderFailureCode2 { get; set; }
        public string? WorkOrderFailureCode3 { get; set; }
        public string? WorkOrderFifthRequester { get; set; }
        public string? WorkOrderFourthRequester { get; set; }
        public decimal WorkOrderInactive { get; set; }
        public string? WorkOrderLocation { get; set; }
        public string? WorkOrderLocationDesc { get; set; }
        public decimal WorkOrderLocked { get; set; }
        public string? WorkOrderManager { get; set; }
        public string? WorkOrderModifyBy { get; set; }
        public DateTime? WorkOrderModifyDate { get; set; }
        public string? WorkOrderNote1 { get; set; }
        public decimal? WorkOrderNote10 { get; set; }
        public string? WorkOrderNote2 { get; set; }
        public string? WorkOrderNote3 { get; set; }
        public string? WorkOrderNote4 { get; set; }
        public string? WorkOrderNote5 { get; set; }
        public string? WorkOrderNote6 { get; set; }
        public string? WorkOrderNote7 { get; set; }
        public string? WorkOrderNote8 { get; set; }
        public decimal WorkOrderNote9 { get; set; }
        public DateTime? WorkOrderOpenDate { get; set; }
        public string? WorkOrderParentWo { get; set; }
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
        public string? WorkOrderSurfLsd { get; set; }
        public string? WorkOrderSurfRange { get; set; }
        public string? WorkOrderSurfSect { get; set; }
        public string? WorkOrderSurfTownShip { get; set; }
        public DateTime? WorkOrderTargetDate { get; set; }
        public DateTime? WorkOrderTargetEndDate { get; set; }
        public string? WorkOrderThirdRequester { get; set; }
        public string? WorkOrderWo1 { get; set; }
        public string? WorkOrderWo2 { get; set; }
        public string? WorkOrderWo3 { get; set; }
        public string? WorkOrderWo4 { get; set; }
        public string? WorkOrderWo5 { get; set; }
        public decimal? WorkOrderWo6 { get; set; }
        public decimal? WorkOrderWo7 { get; set; }
        public decimal? WorkOrderWo8 { get; set; }
        public string WorkOrderWoNum { get; set; } = null!;
        public string? WorkOrderWoSubType { get; set; }
        public string? WorkOrderWoType { get; set; }
        public decimal WomaterialActual { get; set; }
        public decimal WomaterialAddCost { get; set; }
        public decimal WomaterialCbtax1 { get; set; }
        public decimal WomaterialCbtax2 { get; set; }
        public string? WomaterialChangeRemark { get; set; }
        public decimal WomaterialChargeBack { get; set; }
        public decimal WomaterialChargeBackAmount { get; set; }
        public int WomaterialCounter { get; set; }
        public string? WomaterialCrAccount { get; set; }
        public string? WomaterialCreatedBy { get; set; }
        public DateTime? WomaterialCreationDate { get; set; }
        public string? WomaterialDescription { get; set; }
        public decimal WomaterialDirtyLog { get; set; }
        public string? WomaterialDrAccount { get; set; }
        public string? WomaterialEquipSerial { get; set; }
        public decimal WomaterialEstimate { get; set; }
        public decimal WomaterialExtension { get; set; }
        public decimal WomaterialInactive { get; set; }
        public string? WomaterialItemNum { get; set; }
        public decimal WomaterialMarkupAmount { get; set; }
        public string? WomaterialModifyBy { get; set; }
        public DateTime? WomaterialModifyDate { get; set; }
        public string WomaterialOrderType { get; set; } = null!;
        public DateTime? WomaterialPostDate { get; set; }
        public DateTime? WomaterialPrintDate { get; set; }
        public string? WomaterialPrintPerson { get; set; }
        public decimal WomaterialPublicNote { get; set; }
        public decimal WomaterialQuantity { get; set; }
        public decimal? WomaterialRefNum { get; set; }
        public decimal WomaterialReserved { get; set; }
        public string? WomaterialSerialNum { get; set; }
        public string? WomaterialStore { get; set; }
        public string? WomaterialTaskNum { get; set; }
        public decimal WomaterialTax1 { get; set; }
        public string? WomaterialTax1Account { get; set; }
        public decimal WomaterialTax2 { get; set; }
        public string? WomaterialTax2Account { get; set; }
        public DateTime? WomaterialTransDate { get; set; }
        public string? WomaterialUnit { get; set; }
        public decimal WomaterialUnitPrice { get; set; }
        public string? WomaterialVendor { get; set; }
        public string? WomaterialWoNum { get; set; }
    }
}

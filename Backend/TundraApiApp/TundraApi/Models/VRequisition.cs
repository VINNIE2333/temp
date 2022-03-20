using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VRequisition
    {
        public decimal ItemRequestActualCost { get; set; }
        public DateTime? ItemRequestCloseDate { get; set; }
        public string? ItemRequestDepartment { get; set; }
        public string? ItemRequestDescription { get; set; }
        public decimal ItemRequestDirtyLog { get; set; }
        public string? ItemRequestDivision { get; set; }
        public string? ItemRequestDrAccount { get; set; }
        public decimal ItemRequestInactive { get; set; }
        public DateTime? ItemRequestModifyDate { get; set; }
        public DateTime? ItemRequestOpenDate { get; set; }
        public string? ItemRequestOperator { get; set; }
        public string? ItemRequestPhone { get; set; }
        public string? ItemRequestPriority { get; set; }
        public string ItemRequestReqNum { get; set; } = null!;
        public string? ItemRequestRequester { get; set; }
        public DateTime? ItemRequestRequiredDate { get; set; }
        public string? ItemRequestRq1 { get; set; }
        public decimal? ItemRequestRq10 { get; set; }
        public string? ItemRequestRq2 { get; set; }
        public string? ItemRequestRq3 { get; set; }
        public string? ItemRequestRq4 { get; set; }
        public string? ItemRequestRq5 { get; set; }
        public decimal? ItemRequestRq6 { get; set; }
        public decimal? ItemRequestRq7 { get; set; }
        public decimal? ItemRequestRq8 { get; set; }
        public decimal? ItemRequestRq9 { get; set; }
        public string? ItemRequestShipAddress1 { get; set; }
        public string? ItemRequestShipAddress2 { get; set; }
        public string? ItemRequestShipAddress3 { get; set; }
        public string? ItemRequestShipPhone { get; set; }
        public string? ItemRequestShipTo { get; set; }
        public string? ItemRequestStatus { get; set; }
        public decimal ItemRequestStatusFlags { get; set; }
        public decimal ItemRequestTotalCost { get; set; }
        public string? ItemRequestVendor { get; set; }
        public DateTime Printdate2 { get; set; }
        public string? Printdate { get; set; }
        public string InactiveIr { get; set; } = null!;
        public string? ItemRequestCrAccount { get; set; }
        public string? ItemRequestCustomer { get; set; }
    }
}

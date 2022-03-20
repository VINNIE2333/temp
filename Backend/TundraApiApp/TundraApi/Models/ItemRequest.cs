using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class ItemRequest
    {
        public string ReqNum { get; set; } = null!;
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }
        public DateTime? RequiredDate { get; set; }
        public string? Requester { get; set; }
        public string? Phone { get; set; }
        public string? ShipTo { get; set; }
        public string? ShipAddress1 { get; set; }
        public string? ShipAddress2 { get; set; }
        public string? ShipAddress3 { get; set; }
        public string? ShipPhone { get; set; }
        public string? DrAccount { get; set; }
        public decimal TotalCost { get; set; }
        public decimal ActualCost { get; set; }
        public string? Operator { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal Inactive { get; set; }
        public decimal StatusFlags { get; set; }
        public string? Rq1 { get; set; }
        public string? Rq2 { get; set; }
        public string? Rq3 { get; set; }
        public string? Rq4 { get; set; }
        public string? Rq5 { get; set; }
        public decimal? Rq6 { get; set; }
        public decimal? Rq7 { get; set; }
        public decimal? Rq8 { get; set; }
        public decimal? Rq9 { get; set; }
        public decimal? Rq10 { get; set; }
        public string? Division { get; set; }
        public decimal DirtyLog { get; set; }
        public string? Vendor { get; set; }
        public string? Department { get; set; }
        public string? Priority { get; set; }
        public string? CrAccount { get; set; }
        public decimal StatusCode { get; set; }
        public string? ModifyBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal IsKeyRequest { get; set; }
        public string? Location { get; set; }
        public string? LocationDesc { get; set; }
        public string? DeptApprovalId { get; set; }
        public string? DeptSignature { get; set; }
        public DateTime? DeptApprovalDate { get; set; }
        public string? DivisionApprovalId { get; set; }
        public string? DivisionSignature { get; set; }
        public DateTime? DivisionApprovalDate { get; set; }
        public string? AuthorizationId { get; set; }
        public string? AuthorizationSignature { get; set; }
        public DateTime? AuthorizationDate { get; set; }
        public DateTime? NotificationDate { get; set; }
        public DateTime? Rtsdate { get; set; }
        public string? RecipientId { get; set; }
        public string? RecipientFirstName { get; set; }
        public string? RecipientLastName { get; set; }
        public string? RecipientSupervisor { get; set; }
        public string? RecipientLocation { get; set; }
        public DateTime? RecipientStartAccess { get; set; }
        public DateTime? RecipientEndAccess { get; set; }
        public string? FacultyUse { get; set; }
        public string? CredentialStatus { get; set; }
        public string? Customer { get; set; }
    }
}

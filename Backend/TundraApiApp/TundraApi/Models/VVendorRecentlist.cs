using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VVendorRecentlist
    {
        public string CompanyCode { get; set; } = null!;
        public string? VendName { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Zip { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Contact { get; set; }
        public string? Url { get; set; }
        public string? Email { get; set; }
        public decimal Inactive { get; set; }
        public decimal? Tax1 { get; set; }
        public decimal? Tax2 { get; set; }
        public string? Taxid1 { get; set; }
        public string? Taxid2 { get; set; }
        public string? EmpId { get; set; }
        public string? AcctContact { get; set; }
        public string? VendCustId { get; set; }
        public string? VendCategory { get; set; }
        public string? VendTerms { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ContractNum { get; set; }
        public string? VendorCurrency { get; set; }
        public string? ParentId { get; set; }
        public string? Division { get; set; }
        public decimal EmailNotify { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? UserId { get; set; }
        public DateTime? AccessDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VVendor
    {
        public string? VendorAcctContact { get; set; }
        public string? VendorAddress1 { get; set; }
        public string? VendorAddress2 { get; set; }
        public string? VendorCity { get; set; }
        public string VendorCompanyCode { get; set; } = null!;
        public string? VendorContact { get; set; }
        public string? VendorContractNum { get; set; }
        public string? VendorCountry { get; set; }
        public string? VendorDivision { get; set; }
        public string? VendorEmail { get; set; }
        public string? VendorFax { get; set; }
        public string? VendorParentId { get; set; }
        public string? VendorPhone { get; set; }
        public string? VendorState { get; set; }
        public decimal? VendorTax1 { get; set; }
        public decimal? VendorTax2 { get; set; }
        public string? VendorTaxid1 { get; set; }
        public string? VendorTaxid2 { get; set; }
        public string? VendorUrl { get; set; }
        public string? VendorVendCategory { get; set; }
        public string? VendorVendCustId { get; set; }
        public string? VendorVendName { get; set; }
        public string? VendorVendorCurrency { get; set; }
        public string? VendorVendTerms { get; set; }
        public string? VendorZip { get; set; }
        public DateTime Printdate2 { get; set; }
        public string? Printdate { get; set; }
        public string? Cityplusstate { get; set; }
        public string? Countrypluszip { get; set; }
        public decimal VendorInactive { get; set; }
        public string InactiveVendor { get; set; } = null!;
    }
}

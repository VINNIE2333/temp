using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPoPrint
    {
        public decimal PoBaseCurrencyTotal { get; set; }
        public string? PoBillAddress1 { get; set; }
        public string? PoBillAddress2 { get; set; }
        public string? PoBillAddress3 { get; set; }
        public string? PoBillPhone { get; set; }
        public string? PoBillTo { get; set; }
        public DateTime? PoCloseDate { get; set; }
        public string? PoCrAccount { get; set; }
        public string? PoDepartment { get; set; }
        public string? PoDivision { get; set; }
        public string? PoDrAccount { get; set; }
        public string? PoEmpid { get; set; }
        public string? PoExchangeAccount { get; set; }
        public decimal PoExchangeRate { get; set; }
        public decimal PoFreight { get; set; }
        public string? PoManager { get; set; }
        public DateTime? PoOpenDate { get; set; }
        public string? PoPo1 { get; set; }
        public decimal PoPo10 { get; set; }
        public string? PoPo2 { get; set; }
        public string? PoPo3 { get; set; }
        public string? PoPo4 { get; set; }
        public decimal PoPo9 { get; set; }
        public string? PoPoDesc { get; set; }
        public string PoPoNum { get; set; } = null!;
        public decimal PoPoTotal { get; set; }
        public string? PoPotype { get; set; }
        public string? PoPriority { get; set; }
        public DateTime? PoPromisedDate { get; set; }
        public DateTime? PoRequiredDate { get; set; }
        public string? PoShipAddress1 { get; set; }
        public string? PoShipAddress2 { get; set; }
        public string? PoShipAddress3 { get; set; }
        public string? PoShipPhone { get; set; }
        public string? PoShipTo { get; set; }
        public string? PoStatus { get; set; }
        public decimal PoStatuscode { get; set; }
        public decimal PoSubTotal { get; set; }
        public decimal PoTax1Total { get; set; }
        public decimal PoTax2Total { get; set; }
        public string? PoTerms { get; set; }
        public string? PoVendor { get; set; }
        public string? PoVendorCurrency { get; set; }
        public string? VendorAcctContact { get; set; }
        public string? VendorAddress1 { get; set; }
        public string? VendorAddress2 { get; set; }
        public string? VendorCity { get; set; }
        public string? VendorCompanyCode { get; set; }
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
        public string? CityPlusState { get; set; }
        public string? CountryPlusZip { get; set; }
        public decimal? PoTotalWithFreight { get; set; }
        public string? Printdate { get; set; }
        public DateTime Printdate2 { get; set; }
        public string? PoTermsCode { get; set; }
        public string? PoShipAddress4 { get; set; }
        public string? PoShipAddress5 { get; set; }
        public string? PoBillAddress4 { get; set; }
        public string? PoBillAddress5 { get; set; }
        public string? PoCustomer { get; set; }
    }
}

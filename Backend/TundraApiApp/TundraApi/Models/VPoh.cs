using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VPoh
    {
        public decimal? PoBaseCurrencyTotal { get; set; }
        public string? PoBillAddress1 { get; set; }
        public string? PoBillAddress2 { get; set; }
        public string? PoBillAddress3 { get; set; }
        public string? PoBillAddress4 { get; set; }
        public string? PoBillAddress5 { get; set; }
        public string? PoBillPhone { get; set; }
        public string? PoBillTo { get; set; }
        public string? PoChangeRemark { get; set; }
        public DateTime? PoCloseDate { get; set; }
        public string? PoCrAccount { get; set; }
        public string? PoCreatedBy { get; set; }
        public DateTime? PoCreationDate { get; set; }
        public string? PoCustomer { get; set; }
        public string? PoDepartment { get; set; }
        public decimal? PoDirtyLog { get; set; }
        public string? PoDivision { get; set; }
        public string? PoDrAccount { get; set; }
        public string? PoEmpid { get; set; }
        public string? PoExchangeAccount { get; set; }
        public decimal? PoExchangeRate { get; set; }
        public decimal? PoFreight { get; set; }
        public string? PoManager { get; set; }
        public string? PoModifyBy { get; set; }
        public string? PoPoDesc { get; set; }
        public string? PoPoNum { get; set; }
        public string? PoPotype { get; set; }
        public string? PoPriority { get; set; }
        public string? PoShipTo { get; set; }
        public string? PoStatus { get; set; }
        public decimal? PoSubTotal { get; set; }
        public string? PoVendor { get; set; }
        public string? PoVendorCurrency { get; set; }
        public string? PohistoryCreatedBy { get; set; }
        public DateTime? PohistoryCreationDate { get; set; }
        public string? PohistoryModifyBy { get; set; }
        public DateTime? PohistoryModifyDate { get; set; }
        public string? PohistoryOperator { get; set; }
        public string? PohistoryPoNum { get; set; }
        public string? PohistoryRemark { get; set; }
        public int PohistoryCounter { get; set; }
        public decimal? PoPoTotal { get; set; }
    }
}

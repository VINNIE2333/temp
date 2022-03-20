using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VLabour
    {
        public string? EmployeeAddress1 { get; set; }
        public string? EmployeeAddress2 { get; set; }
        public string? EmployeeCity { get; set; }
        public string? EmployeeContact { get; set; }
        public string? EmployeeCountry { get; set; }
        public string? EmployeeCrAccount { get; set; }
        public string? EmployeeCraft { get; set; }
        public string? EmployeeDepartment { get; set; }
        public decimal EmployeeDirtylog { get; set; }
        public string? EmployeeDivision { get; set; }
        public string? EmployeeDrAccount { get; set; }
        public string? EmployeeEmail { get; set; }
        public decimal EmployeeEmailNotify { get; set; }
        public string? EmployeeEmpgroup { get; set; }
        public string EmployeeEmpid { get; set; } = null!;
        public decimal EmployeeEmployee { get; set; }
        public string? EmployeeEmppword { get; set; }
        public string? EmployeeEmpTitle { get; set; }
        public string? EmployeeFax { get; set; }
        public string? EmployeeFirstName { get; set; }
        public DateTime? EmployeeHireDate { get; set; }
        public decimal EmployeeInactive { get; set; }
        public string? EmployeeLab1 { get; set; }
        public string? EmployeeLab2 { get; set; }
        public string? EmployeeLab3 { get; set; }
        public string? EmployeeLab4 { get; set; }
        public string? EmployeeLastName { get; set; }
        public string? EmployeeLocation { get; set; }
        public string? EmployeeManager { get; set; }
        public string? EmployeePhone { get; set; }
        public decimal EmployeeRate { get; set; }
        public string? EmployeeState { get; set; }
        public decimal EmployeeSystem { get; set; }
        public string? EmployeeUrl { get; set; }
        public string? EmployeeUserFlags { get; set; }
        public string? EmployeeZip { get; set; }
        public string? FullName { get; set; }
        public string? CityAndState { get; set; }
        public string InactiveYesNo { get; set; } = null!;
        public string EmployeeYesNo { get; set; } = null!;
        public string? Printdate { get; set; }
        public DateTime Printdate2 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Employee
    {
        public string Empid { get; set; } = null!;
        public string? LastName { get; set; }
        public string? FirstName { get; set; }
        public string? Craft { get; set; }
        public DateTime? HireDate { get; set; }
        public decimal Rate { get; set; }
        public string? Location { get; set; }
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
        public decimal Employee1 { get; set; }
        public string? Emppword { get; set; }
        public string? EmpGroup { get; set; }
        public decimal Inactive { get; set; }
        public string? Lab1 { get; set; }
        public string? Lab2 { get; set; }
        public string? Lab3 { get; set; }
        public string? Lab4 { get; set; }
        public string? Division { get; set; }
        public decimal System { get; set; }
        public decimal DirtyLog { get; set; }
        public string? Userflags { get; set; }
        public decimal EmailNotify { get; set; }
        public string? EmpTitle { get; set; }
        public string? Department { get; set; }
        public string? Manager { get; set; }
        public string? CrAccount { get; set; }
        public string? DrAccount { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public decimal? Lcid { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? ChangeRemark { get; set; }
        public string? Lab5 { get; set; }
        public string? StandardRate { get; set; }
        public string? Accepted { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Manufacturer
    {
        public string CompanyCode { get; set; } = null!;
        public string? MName { get; set; }
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
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VCustomerRecentList
    {
        public string Customer { get; set; } = null!;
        public string? CompanyType { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Zipcode { get; set; }
        public string? Telephone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? Division { get; set; }
        public string? Region { get; set; }
        public string? WebPage { get; set; }
        public DateTime? LastContact { get; set; }
        public DateTime? NextContact { get; set; }
        public string? Status { get; set; }
        public string? Owner { get; set; }
        public string? Category { get; set; }
        public string? Currency { get; set; }
        public string? Location { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? CreatedBy { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public decimal? Recno { get; set; }
        public DateTime? AccessDate { get; set; }
        public string? UserId { get; set; }
        public string? DrAccount { get; set; }
        public string? CrAccount { get; set; }
        public decimal Inactive { get; set; }
        public string? Memo { get; set; }
        public decimal Mail { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class Vcontact
    {
        public string? LinkId { get; set; }
        public string? LinkType { get; set; }
        public string? CtName { get; set; }
        public string? CtTitle { get; set; }
        public string? CtPhone { get; set; }
        public string? CtFax { get; set; }
        public string? CtEmail { get; set; }
        public int Counter { get; set; }
        public string? ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal DirtyLog { get; set; }
        public string? ChangeRemark { get; set; }
        public string? MrMs { get; set; }
        public string? Name1 { get; set; }
        public string? Name2 { get; set; }
        public string? Surname { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? Zipcode { get; set; }
        public string? Extension { get; set; }
        public string? Cel { get; set; }
        public string? Region { get; set; }
        public DateTime? LastContact { get; set; }
        public DateTime? NextContact { get; set; }
        public string? Status { get; set; }
        public string? Memo { get; set; }
        public string? Owner { get; set; }
        public decimal Mail { get; set; }
        public string? Location { get; set; }
        public decimal Inactive { get; set; }
        public string? Ctype { get; set; }
    }
}

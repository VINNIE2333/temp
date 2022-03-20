using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class UserWorkList
    {
        public int Counter { get; set; }
        public string? UserId { get; set; }
        public string? LinkId { get; set; }
        public string? LinkModule { get; set; }
        public string? LinkType { get; set; }
        public DateTime? TransDate { get; set; }
    }
}

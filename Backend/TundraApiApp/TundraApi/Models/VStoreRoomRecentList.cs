using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VStoreRoomRecentList
    {
        public string StoreRoom { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Inactive { get; set; }
        public decimal DirtyLog { get; set; }
        public string? Division { get; set; }
        public string? ChangeRemark { get; set; }
        public string? UserId { get; set; }
        public DateTime? AccessDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VInventorymain
    {
        public decimal InvLotCounter { get; set; }
        public decimal VInventoryStoreroomMaxStock { get; set; }
        public decimal? VInventoryStoreroomQtyOnHand { get; set; }
    }
}

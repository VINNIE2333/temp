using System;
using System.Collections.Generic;

namespace TundraApi.Models
{
    public partial class VCurrchangerate
    {
        public string? Currency { get; set; }
        public decimal Exchangerate { get; set; }
        public DateTime? Exchangedate { get; set; }
    }
}

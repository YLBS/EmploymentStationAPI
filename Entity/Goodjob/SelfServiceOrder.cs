using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class SelfServiceOrder
    {
        public string OutTradeNo { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Detail { get; set; }
        public string TotalAmout { get; set; } = null!;
        public int Type { get; set; }
        public int VipLeveId { get; set; }
        public bool WhetherPay { get; set; }
        public int MemId { get; set; }
    }
}

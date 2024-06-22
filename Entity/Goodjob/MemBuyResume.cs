using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemBuyResume
    {
        public int OrderId { get; set; }
        public int MemId { get; set; }
        public int PayMoney { get; set; }
        public string Description { get; set; } = null!;
        public string PayPerson { get; set; } = null!;
        public DateTime PayDate { get; set; }
        public byte DoFlag { get; set; }
    }
}

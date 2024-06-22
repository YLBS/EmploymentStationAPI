using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class EvaluateItem
    {
        public Guid Id { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public int? Fraction { get; set; }
        public string? Remark { get; set; }
        public DateTime? InTime { get; set; }
    }
}

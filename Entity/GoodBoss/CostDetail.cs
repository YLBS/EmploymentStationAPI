using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CostDetail
    {
        public int Id { get; set; }
        public int? CostTypeId { get; set; }
        public string? CostTypeName { get; set; }
        public decimal? CostValue { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public string? Remark { get; set; }
        public DateTime? InTime { get; set; }
        public string? AdminName { get; set; }
        public short? State { get; set; }
        public DateTime? HappenTime { get; set; }
    }
}

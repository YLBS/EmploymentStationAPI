using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class EvaluateScore
    {
        public Guid Id { get; set; }
        public Guid? RecordId { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public int? CateId { get; set; }
        public int? ItemId { get; set; }
        public string? ItemName { get; set; }
        public decimal? Fraction { get; set; }
        public int? MarkEplId { get; set; }
        public string? MarkEplName { get; set; }
        public string? Remark { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? CallTime { get; set; }
    }
}

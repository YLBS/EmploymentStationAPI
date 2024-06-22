using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class Invoice
    {
        public int InId { get; set; }
        public decimal? Amount { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public int? InType { get; set; }
        public int? EplId { get; set; }
        public int? DptId { get; set; }
        public string? EplName { get; set; }
        public string? DptName { get; set; }
        public string? Remark { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? RegTime { get; set; }
        public int? State { get; set; }
        public int? CheckEplId { get; set; }
        public string? CheckEplName { get; set; }
        public int? CheckDptId { get; set; }
        public string? CheckDptName { get; set; }
        public DateTime? CheckTime { get; set; }
        public string? CheckRemark { get; set; }
    }
}

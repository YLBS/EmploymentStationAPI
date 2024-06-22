using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class FinAdAmount
    {
        public int FadId { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public int? AdType { get; set; }
        public string? AdName { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public decimal? Revenue { get; set; }
        public DateTime? ReTime { get; set; }
        public int? InputEplId { get; set; }
        public string? InputEplName { get; set; }
        public DateTime? InTime { get; set; }
        public short? RevenueType { get; set; }
        public string? Remark { get; set; }
        public bool? Delflag { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ClientRecommend
    {
        public int? RecId { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? MemId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EntTime { get; set; }
        public int? State { get; set; }
        public int? CheckEplId { get; set; }
        public string? CheckEplName { get; set; }
        public string? CheckRemark { get; set; }
        public DateTime? CheckTime { get; set; }
        public string? Remark { get; set; }
    }
}

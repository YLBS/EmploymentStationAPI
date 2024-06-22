using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PackScrap
    {
        public int ScrId { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public DateTime? ScrapTime { get; set; }
        public DateTime? InTime { get; set; }
        public string? Remark { get; set; }
        public short? State { get; set; }
        public int? CheckEplId { get; set; }
        public string? CheckEplName { get; set; }
        public string? CheckRemark { get; set; }
        public DateTime? CheckTime { get; set; }
    }
}

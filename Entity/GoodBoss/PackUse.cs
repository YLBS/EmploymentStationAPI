using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PackUse
    {
        public int UseId { get; set; }
        public int? EplId { get; set; }
        public int? DptId { get; set; }
        public string? EplName { get; set; }
        public string? DptName { get; set; }
        public DateTime? UseTime { get; set; }
        public DateTime? InTime { get; set; }
        public string? Remark { get; set; }
        public int? OperEplId { get; set; }
        public string? OperEplName { get; set; }
        public short? State { get; set; }
        public int? CheckEplId { get; set; }
        public string? CheckEplName { get; set; }
        public string? CheckRemark { get; set; }
        public string? CheckTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PackLog
    {
        public string LogId { get; set; } = null!;
        public string? Number { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public string? LogType { get; set; }
        public DateTime? InTime { get; set; }
        public string? IpAddress { get; set; }
        public string? Remark { get; set; }
    }
}

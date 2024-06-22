using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysGoodjobLoginLog
    {
        public string GllId { get; set; } = null!;
        public string? UserName { get; set; }
        public int? EplId { get; set; }
        public short? State { get; set; }
        public string? Randomchar { get; set; }
        public string? LoginIp { get; set; }
        public DateTime? LoginTime { get; set; }
        public string? LoginEplName { get; set; }
        public DateTime? IntTime { get; set; }
    }
}

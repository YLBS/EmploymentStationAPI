using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmAbnegateLog
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int AngId { get; set; }
        public string Reason { get; set; } = null!;
        public int EplId { get; set; }
        public DateTime AngDate { get; set; }
        public string? EplIp { get; set; }
        public int? CsId { get; set; }
    }
}

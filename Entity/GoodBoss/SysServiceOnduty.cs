using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysServiceOnduty
    {
        public string SoId { get; set; } = null!;
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public DateTime? DutyDate { get; set; }
        public DateTime? Intime { get; set; }
        public string? Remark { get; set; }
    }
}

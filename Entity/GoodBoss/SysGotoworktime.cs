using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysGotoworktime
    {
        public DateTime? Worktime { get; set; }
        public string? Morningtime { get; set; }
        public string? Afternoontime { get; set; }
        public int? MorningRecess { get; set; }
        public int? AfterRecess { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class HrHoliday
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public byte Type { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Title { get; set; } = null!;
        public string Memo { get; set; } = null!;
        public DateTime CheckDate { get; set; }
        public byte CheckSate { get; set; }
        public int CheckManUid { get; set; }
        public string Checkmemo { get; set; } = null!;
        public DateTime? Intime { get; set; }
    }
}

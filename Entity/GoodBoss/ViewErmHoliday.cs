using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewErmHoliday
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public byte Type { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public byte Checksate { get; set; }
        public string? Hname { get; set; }
        public string Memo { get; set; } = null!;
        public string? EplName { get; set; }
        public string? Myname { get; set; }
        public DateTime CheckDate { get; set; }
        public string Checkmemo { get; set; } = null!;
        public string? PassMan { get; set; }
        public int Uid { get; set; }
        public int? DptId { get; set; }
        public string IsPass { get; set; } = null!;
        public string? PosiName { get; set; }
    }
}

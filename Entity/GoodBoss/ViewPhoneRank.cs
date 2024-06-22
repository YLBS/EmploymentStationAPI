using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewPhoneRank
    {
        public int EplId { get; set; }
        public int DptId { get; set; }
        public string EplName { get; set; } = null!;
        public int EsId { get; set; }
        public int Enable { get; set; }
        public int? CurrentDayCount { get; set; }
        public int CurrentDaySum { get; set; }
        public int? CurrentMonthCount { get; set; }
        public int CurrentMonthSum { get; set; }
        public int YesterdayDaySum { get; set; }
        public string? Picture { get; set; }
        public string? DptName { get; set; }
    }
}

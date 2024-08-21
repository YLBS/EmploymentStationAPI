using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngWxPushLimit
    {
        public int Id { get; set; }
        public string CalingName { get; set; } = null!;
        public string MemKeyWored { get; set; } = null!;
        public string MemId { get; set; } = null!;
        public string PosKeyWored { get; set; } = null!;
        public string RegionCid { get; set; } = null!;
        public int DayCount { get; set; }
        public int EplDayCount { get; set; }
        public bool UseKeyWordFilter { get; set; }
        public int EplDayMinute { get; set; }
    }
}

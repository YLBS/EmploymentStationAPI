using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    /// <summary>
    /// 珠宝园区资讯
    /// </summary>
    public partial class ParkNews
    {
        public int NewsId { get; set; }
        public string Title { get; set; } = null!;
        public int MemId { get; set; }
        public string ContentText { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int HitCount { get; set; }
        public byte AdFlag { get; set; }
        public int ParkType { get; set; }
    }
}

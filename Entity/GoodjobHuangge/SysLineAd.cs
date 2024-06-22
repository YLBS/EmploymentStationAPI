using System;
using System.Collections.Generic;

namespace Entity.GoodjobHuangge
{
    public partial class SysLineAd
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string Name { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string LinkUrl { get; set; } = null!;
        public int ClassId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsFlash { get; set; }
        public int SpaceCount { get; set; }
        public int TopValue { get; set; }
        public int HitCount { get; set; }
        public byte AdFlag { get; set; }
        public DateTime AddDate { get; set; }
        public int AddUserId { get; set; }
        public int SiteId { get; set; }
        public string? TxtRemark { get; set; }
        public int? TownId { get; set; }
    }
}

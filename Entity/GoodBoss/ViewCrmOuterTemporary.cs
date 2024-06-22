using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmOuterTemporary
    {
        public int ComId { get; set; }
        public DateTime InputDate { get; set; }
        public DateTime OuterRefleshDate { get; set; }
        public string FromSite { get; set; } = null!;
        public string? ComName { get; set; }
        public string? Address { get; set; }
        public int? CsId { get; set; }
        public int PosCount { get; set; }
        public string OuterSiteUrl { get; set; } = null!;
        public DateTime? Cetime { get; set; }
        public DateTime? Cstime { get; set; }
        public string? Pname { get; set; }
        public string? CityName { get; set; }
        public string? TownName { get; set; }
        public bool IsFree { get; set; }
        public int? TownId { get; set; }
        public int? CityId { get; set; }
        public int? ProvId { get; set; }
        public DateTime? CabandonTime { get; set; }
        public int IsNewInput { get; set; }
        public int LastLinkEplId { get; set; }
        public int? MemId { get; set; }
        public string? CsName { get; set; }
        public int HasContact { get; set; }
        public string? EplName { get; set; }
        public int? EplId { get; set; }
        public int? DptId { get; set; }
        public string NewestPosName { get; set; } = null!;
    }
}

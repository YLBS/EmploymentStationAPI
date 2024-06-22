using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmOuter
    {
        public DateTime OuterRefleshDate { get; set; }
        public DateTime InputDate { get; set; }
        public string FromSite { get; set; } = null!;
        public int PosCount { get; set; }
        public string OuterSiteUrl { get; set; } = null!;
        public string? ComName { get; set; }
        public DateTime? LastLinkDate { get; set; }
        public string? EplName { get; set; }
        public string? DptName { get; set; }
        public DateTime? CabandonTime { get; set; }
        public int ComId { get; set; }
        public int? FinId { get; set; }
        public string? CollEplName { get; set; }
        public int LastLinkEplId { get; set; }
        public int? CsId { get; set; }
    }
}

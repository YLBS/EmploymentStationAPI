using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmExpirationDisplay
    {
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public int EplId { get; set; }
        public string CollEplName { get; set; } = null!;
        public DateTime Cetime { get; set; }
        public DateTime OuterRefleshDate { get; set; }
        public string FromSite { get; set; } = null!;
        public string OuterSiteUrl { get; set; } = null!;
        public DateTime InputDate { get; set; }
        public string? EplName { get; set; }
        public string? DptName { get; set; }
        public DateTime LastTradeDate { get; set; }
        public int HasGet { get; set; }
        public int CountDown { get; set; }
        public int GetEplId { get; set; }
        public int? CsId { get; set; }
    }
}

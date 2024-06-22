using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmNewsAd
    {
        public int NewsAdId { get; set; }
        public int StandId { get; set; }
        public int StandType { get; set; }
        public int OrderById { get; set; }
        public int EplId { get; set; }
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public DateTime ApplyTime { get; set; }
        public int AuditType { get; set; }
        public string EplName { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}

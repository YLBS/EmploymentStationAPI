using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmNewsAd
    {
        public int NewsAdId { get; set; }
        public int StandId { get; set; }
        public int StandType { get; set; }
        public int OrderById { get; set; }
        public int EplId { get; set; }
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public DateTime ApplyTime { get; set; }
        public string ContentText { get; set; } = null!;
        public int AuditType { get; set; }
        public int AdLevel { get; set; }
        public string PositionText { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmAdCount
    {
        public int CountId { get; set; }
        public int PlaceId { get; set; }
        public int SumApply { get; set; }
        public int SumCheck { get; set; }
        public int SumOnline { get; set; }
        public DateTime? HaveSpaceDate { get; set; }
        public DateTime? OnlineEndDate { get; set; }
    }
}

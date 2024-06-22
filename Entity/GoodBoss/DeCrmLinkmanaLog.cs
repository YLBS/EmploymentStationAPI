using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class DeCrmLinkmanaLog
    {
        public int Id { get; set; }
        public int LnkId { get; set; }
        public int Eplid { get; set; }
        public DateTime DeleteTime { get; set; }
    }
}

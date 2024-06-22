using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ClientCurveDetail
    {
        public int CdId { get; set; }
        public int? CurveId { get; set; }
        public int? Sequence { get; set; }
        public int? CurveValue { get; set; }
        public int? CurrSum { get; set; }
        public short? IsLast { get; set; }
        public int? EplId { get; set; }
    }
}

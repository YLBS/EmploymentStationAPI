using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ClientTrackingCurve
    {
        public int CurId { get; set; }
        public string? CurveName { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? Layer { get; set; }
        public DateTime? InTime { get; set; }
        public string? Remark { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmStand
    {
        public int StandId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime AtTheTime { get; set; }
        public int StandType { get; set; }
        public string Matters { get; set; } = null!;
        public int InputEplId { get; set; }
        public string NumberCount { get; set; } = null!;
        public DateTime EndDateTime { get; set; }
        public int Dptid { get; set; }
        public int? Dptid2 { get; set; }
        public string EplIds { get; set; } = null!;
    }
}

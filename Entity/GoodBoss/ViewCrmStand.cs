using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmStand
    {
        public int StandId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime AtTheTime { get; set; }
        public int StandType { get; set; }
        public string Matters { get; set; } = null!;
        public string NumberCount { get; set; } = null!;
        public int InputEplId { get; set; }
        public string StandTypeName { get; set; } = null!;
        public int? Count { get; set; }
        public DateTime EndDateTime { get; set; }
        public int One { get; set; }
    }
}

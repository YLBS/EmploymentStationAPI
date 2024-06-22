using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ClerkGoup
    {
        public int EplId { get; set; }
        public string? EplName { get; set; }
        public decimal? Commonclerk { get; set; }
        public decimal? Starclerk { get; set; }
        public decimal? Jinyingclerk { get; set; }
        public decimal? Advancedclerk { get; set; }
        public decimal? Manager { get; set; }
        public int? State { get; set; }
        public DateTime? Starttime { get; set; }
    }
}

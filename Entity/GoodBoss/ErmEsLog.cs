using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ErmEsLog
    {
        public int Id { get; set; }
        public string? EplId { get; set; }
        public int EsId { get; set; }
        public int OEplId { get; set; }
        public string? Oip { get; set; }
        public string Cause { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ClientRepeat
    {
        public int RepeatId { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public string? Remark { get; set; }
        public DateTime? Intime { get; set; }
        public int? State { get; set; }
    }
}

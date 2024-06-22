using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmDeleteLog
    {
        public int Id { get; set; }
        public string ComId { get; set; } = null!;
        public int EplId { get; set; }
        public DateTime InDate { get; set; }
        public string Type { get; set; } = null!;
        public string? Ip { get; set; }
    }
}

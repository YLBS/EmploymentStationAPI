using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ForumOnline
    {
        public int Id { get; set; }
        public string? EplName { get; set; }
        public DateTime? InTime { get; set; }
        public string? InIp { get; set; }
    }
}

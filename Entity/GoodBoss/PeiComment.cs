using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PeiComment
    {
        public int Id { get; set; }
        public int? FileId { get; set; }
        public string? Comment { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public string? EplIp { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime? Regtime { get; set; }
    }
}

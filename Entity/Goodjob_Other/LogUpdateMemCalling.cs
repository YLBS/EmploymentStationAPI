using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class LogUpdateMemCalling
    {
        public int Id { get; set; }
        public int? MemId { get; set; }
        public int? OldCalling { get; set; }
        public int? NewCalling { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? UserId { get; set; }
        public string? LoginIp { get; set; }
    }
}

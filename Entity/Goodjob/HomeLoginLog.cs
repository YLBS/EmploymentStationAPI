using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class HomeLoginLog
    {
        public string GllId { get; set; } = null!;
        public string? UserName { get; set; }
        public int? MyUserId { get; set; }
        public short? State { get; set; }
        public string? Randomchar { get; set; }
        public string? LoginIp { get; set; }
        public DateTime? LoginTime { get; set; }
        public string? LoginName { get; set; }
        public DateTime? IntTime { get; set; }
    }
}

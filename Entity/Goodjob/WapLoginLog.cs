using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class WapLoginLog
    {
        public int MyuserId { get; set; }
        public string? MyName { get; set; }
        public DateTime? LastCheckInDate { get; set; }
        public DateTime? LastReFreshDate { get; set; }
        public int? Logincount { get; set; }
        public int? Sxcount { get; set; }
    }
}

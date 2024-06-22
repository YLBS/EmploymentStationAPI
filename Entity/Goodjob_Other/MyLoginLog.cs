using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class MyLoginLog
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public DateTime LoginDate { get; set; }
        public string LoginIp { get; set; } = null!;
    }
}

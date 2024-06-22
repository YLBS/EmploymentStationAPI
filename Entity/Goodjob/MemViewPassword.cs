using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemViewPassword
    {
        public int MyUserId { get; set; }
        public int MemId { get; set; }
        public string MemName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public DateTime Lookdate { get; set; }
        public string LastLoginIp { get; set; } = null!;
    }
}

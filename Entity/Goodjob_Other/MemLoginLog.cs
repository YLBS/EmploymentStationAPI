using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class MemLoginLog
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public DateTime LoginDate { get; set; }
        public string LoginIp { get; set; } = null!;
        public byte? LoginType { get; set; }
        public int ClientType { get; set; }
        public string UserName { get; set; } = null!;
    }
}

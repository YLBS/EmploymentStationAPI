using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class MngMemLoginLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MemId { get; set; }
        public DateTime LoginDate { get; set; }
        public string? LoginIp { get; set; }
    }
}

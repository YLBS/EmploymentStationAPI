using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class LogUpdateMemName
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string OldName { get; set; } = null!;
        public string NewName { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public int UserId { get; set; }
        public string LoginIp { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class HtrReward
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public string MemName { get; set; } = null!;
        public string PosName { get; set; } = null!;
        public string MyName { get; set; } = null!;
        public string MyEmail { get; set; } = null!;
        public string MyPhone { get; set; } = null!;
        public string ResumeReason { get; set; } = null!;
        public string WordFile { get; set; } = null!;
        public DateTime ApplyTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubResumeViewLog
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int MemId { get; set; }
        public DateTime OperateDate { get; set; }
        public string OperateIp { get; set; } = null!;
    }
}

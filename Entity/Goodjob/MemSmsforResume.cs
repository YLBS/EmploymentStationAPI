using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSmsforResume
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public int SentCount { get; set; }
        public DateTime LatestSendTime { get; set; }
        public int SendType { get; set; }
    }
}

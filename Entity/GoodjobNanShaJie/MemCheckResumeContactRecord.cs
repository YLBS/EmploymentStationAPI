using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemCheckResumeContactRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime? LastTime { get; set; }
        public DateTime CreatTime { get; set; }
        public int CheckCount { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLiveConfereePo
    {
        public int Id { get; set; }
        public int LiveId { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}

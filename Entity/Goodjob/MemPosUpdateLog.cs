using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPosUpdateLog
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public byte UpdateFlag { get; set; }
        public DateTime Updatetime { get; set; }
    }
}

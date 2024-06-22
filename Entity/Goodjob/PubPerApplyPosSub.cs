using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubPerApplyPosSub
    {
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}

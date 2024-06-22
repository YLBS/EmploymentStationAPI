using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPosNoRefresh
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsFlag { get; set; }
    }
}

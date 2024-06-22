using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemHiresLog
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        public string PosName { get; set; } = null!;
        public DateTime HiresDate { get; set; }
        public DateTime EndHiresDate { get; set; }
    }
}

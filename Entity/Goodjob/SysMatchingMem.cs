using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class SysMatchingMem
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public DateTime? CreateTime { get; set; }
        public int ApplyCount { get; set; }
        public bool IsDell { get; set; }
    }
}

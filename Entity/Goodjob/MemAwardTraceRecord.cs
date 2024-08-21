using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemAwardTraceRecord
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public int MemId { get; set; }
        public int TraceType { get; set; }
        public string Content { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemResumeTag
    {
        public int TagId { get; set; }
        public int TagColor { get; set; }
        public string TagTitle { get; set; } = null!;
        public int MemId { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

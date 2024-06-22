using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSetResumeTag
    {
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public int TagId { get; set; }
        public int TagType { get; set; }
        public DateTime SetDateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyResumePerNameRecord
    {
        public int MyUserId { get; set; }
        public string OldPerName { get; set; } = null!;
        public string NewPerName { get; set; } = null!;
        public DateTime? UpdateTime { get; set; }
    }
}

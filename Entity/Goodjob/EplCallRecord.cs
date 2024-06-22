using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class EplCallRecord
    {
        public int Id { get; set; }
        public int EplId { get; set; }
        public int MyUserId { get; set; }
        public int CallCount { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}

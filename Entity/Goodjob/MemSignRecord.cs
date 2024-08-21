using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSignRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public DateTime FirstSignTime { get; set; }
        public DateTime LastSignTime { get; set; }
        public int? ConsecutiveSignDays { get; set; }
    }
}

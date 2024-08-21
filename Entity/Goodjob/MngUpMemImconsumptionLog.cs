using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngUpMemImconsumptionLog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MemId { get; set; }
        public DateTime CreateTime { get; set; }
        public string Content { get; set; } = null!;
    }
}

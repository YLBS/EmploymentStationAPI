using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemProductUserLog
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MaxProductNum { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime OpenDate { get; set; }
        public int UserId { get; set; }
        public string UserIp { get; set; } = null!;
    }
}

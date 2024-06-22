using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemWzpVisitor
    {
        public int Id { get; set; }
        public int WzpId { get; set; }
        public string VisitorIp { get; set; } = null!;
        public DateTime VisitorTime { get; set; }
        public int MemId { get; set; }
        public int Wzptype { get; set; }
    }
}

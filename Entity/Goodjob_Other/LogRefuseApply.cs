using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class LogRefuseApply
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        public string RefuseMemo { get; set; } = null!;
        public DateTime RefuseDate { get; set; }
    }
}

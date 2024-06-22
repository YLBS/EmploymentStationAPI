using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ErmOvertime
    {
        public int Id { get; set; }
        public string ApplyDepart { get; set; } = null!;
        public string ApplyPerNameId { get; set; } = null!;
        public DateTime ApplyDate { get; set; }
        public string OvertimeDate { get; set; } = null!;
        public string BeginTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public string TtlTime { get; set; } = null!;
        public string Why { get; set; } = null!;
        public string? Remark { get; set; }
        public string? PassPerName { get; set; }
        public string? PassDate { get; set; }
        public string ApplyStatus { get; set; } = null!;
    }
}

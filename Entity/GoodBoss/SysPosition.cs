using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysPosition
    {
        public int PosId { get; set; }
        public int? ParentId { get; set; }
        public int? DptId { get; set; }
        public string? PosName { get; set; }
        public string? Alias { get; set; }
        public short? TypeId { get; set; }
        public short? Enable { get; set; }
        public int? Sequence { get; set; }
        public int? DyId { get; set; }
        public string? Memo { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string? DutyName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmProductBond
    {
        public int ProId { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public short? State { get; set; }
        public short? Type { get; set; }
        public int? Number { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public DateTime? IntTime { get; set; }
        public string? Remark { get; set; }
        public int? Int1 { get; set; }
        public string? Str1 { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PackType
    {
        public int PtId { get; set; }
        public int? ParentId { get; set; }
        public string? TypeName { get; set; }
        public string? Remark { get; set; }
        public DateTime? InTime { get; set; }
    }
}

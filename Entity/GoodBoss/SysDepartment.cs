using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysDepartment
    {
        public int DptId { get; set; }
        public int? ParentId { get; set; }
        public string? DptName { get; set; }
        public string? Alias { get; set; }
        public int? TypeId { get; set; }
        public int? Sequence { get; set; }
        public byte? Enable { get; set; }
        public string? Memo { get; set; }
        public DateTime? RegisterDate { get; set; }
        public int GiveupId { get; set; }
    }
}

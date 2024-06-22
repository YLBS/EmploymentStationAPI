using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class TaskMember
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? EplId { get; set; }
        public DateTime? InTime { get; set; }
        public string? Remark { get; set; }
        public short? State { get; set; }
        public bool? IsAdmin { get; set; }
    }
}

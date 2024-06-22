using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class TaskProcess
    {
        public int Id { get; set; }
        public int? TaskId { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public DateTime? FollowTime { get; set; }
        public string? Remark { get; set; }
        public short? Type { get; set; }
        public int? GroupId { get; set; }
        public string? GroupName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class TaskList
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public string? GroupName { get; set; }
        public int? EplId { get; set; }
        public string? EplIname { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? Import { get; set; }
        public short? State { get; set; }
        public short? InputType { get; set; }
        public string? Jobs { get; set; }
        public DateTime? InTime { get; set; }
        public string? Remark { get; set; }
    }
}

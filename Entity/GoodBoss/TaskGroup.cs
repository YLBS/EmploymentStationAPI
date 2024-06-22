using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class TaskGroup
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public int? ClassId { get; set; }
        public DateTime? BuildTime { get; set; }
        public short? State { get; set; }
    }
}

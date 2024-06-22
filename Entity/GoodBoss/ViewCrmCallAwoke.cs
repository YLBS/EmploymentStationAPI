using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmCallAwoke
    {
        public int Id { get; set; }
        public string? Idvalue { get; set; }
        public string? Url { get; set; }
        public string? Title { get; set; }
        public string? Remark { get; set; }
        public string? Name { get; set; }
        public DateTime? WakeTime { get; set; }
        public bool? IsFinish { get; set; }
        public int? ComeFrom { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public DateTime? InTime { get; set; }
        public DateTime Awokedate { get; set; }
        public int? EplId1 { get; set; }
        public bool? Finishflag { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewClientCollaborative
    {
        public int CollId { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public short? State { get; set; }
        public int? CollEplid { get; set; }
        public string? CollEplname { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Importance { get; set; }
        public int Progress { get; set; }
        public string? Remark { get; set; }
        public DateTime? InTime { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CmbManage
    {
        public int Id { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public string? DptName { get; set; }
        public decimal? Cost { get; set; }
        public short? InType { get; set; }
        public DateTime? InTime { get; set; }
        public string? Remark { get; set; }
        public short? State { get; set; }
    }
}

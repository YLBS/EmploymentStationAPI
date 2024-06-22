using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmCessionLog
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int FEplId { get; set; }
        public int FCsId { get; set; }
        public string CessionReason { get; set; } = null!;
        public int TEplId { get; set; }
        public int? TCsId { get; set; }
        public DateTime CessionDate { get; set; }
        public int Status { get; set; }
        public string InceptReason { get; set; } = null!;
        public DateTime? InceptDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public int? AdminUid { get; set; }
        public string? AdminIp { get; set; }
    }
}

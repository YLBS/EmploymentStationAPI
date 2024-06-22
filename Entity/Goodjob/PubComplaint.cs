using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubComplaint
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int MemId { get; set; }
        public int? SalerUserId { get; set; }
        public string? SalerUserName { get; set; }
        public int Type { get; set; }
        public string? Content { get; set; }
        public DateTime AddTime { get; set; }
        public bool HasDealWith { get; set; }
        public int? PosId { get; set; }
        public string ProcessingDetail { get; set; } = null!;
    }
}

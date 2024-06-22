using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class HtrPosition
    {
        public int PosId { get; set; }
        public int? MemId { get; set; }
        public string? PosName { get; set; }
        public int? PosfunBig1 { get; set; }
        public int? PosfunBig2 { get; set; }
        public string? Posdecription { get; set; }
        public string? RequestTxt { get; set; }
        public string? PayTxt { get; set; }
        public string? Address { get; set; }
        public int? DelFlag { get; set; }
        public DateTime? InTime { get; set; }
        public string? CompanyName { get; set; }
        public string? Reward { get; set; }
        public int? YnFlag { get; set; }
    }
}

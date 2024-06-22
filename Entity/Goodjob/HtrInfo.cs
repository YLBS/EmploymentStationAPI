using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class HtrInfo
    {
        public int MemId { get; set; }
        public string? MemName { get; set; }
        public int? Calling { get; set; }
        public string? CompanyIntroduction { get; set; }
        public int? EplId { get; set; }
        public int? DelFlag { get; set; }
        public DateTime? InTime { get; set; }
        public int? Position { get; set; }
    }
}

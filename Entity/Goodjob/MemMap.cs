using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemMap
    {
        public int? MemId { get; set; }
        public string? MapUrl { get; set; }
        public bool? YnOpen { get; set; }
        public DateTime? OpenTime { get; set; }
    }
}

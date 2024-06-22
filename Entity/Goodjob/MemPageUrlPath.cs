using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemPageUrlPath
    {
        public int MemId { get; set; }
        public string UrlPath { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
    }
}

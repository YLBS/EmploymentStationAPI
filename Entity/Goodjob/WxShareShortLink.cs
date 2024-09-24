using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class WxShareShortLink
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string ShortLink { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZhaoPinHuiNews
    {
        public int Pid { get; set; }
        public string Title { get; set; } = null!;
        public string ContentText { get; set; } = null!;
        public DateTime EditDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int? AdFlag { get; set; }
        public byte Type { get; set; }
        public int? HotCount { get; set; }
    }
}

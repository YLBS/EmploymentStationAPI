using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewZphTheme
    {
        public int ZhaoPinHuiId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime AtTheTime { get; set; }
        public string Address { get; set; } = null!;
        public int Number { get; set; }
        public DateTime ByTheTime { get; set; }
        public string Matters { get; set; } = null!;
        public DateTime UpdateDate { get; set; }
        public DateTime EditDate { get; set; }
        public int EplId { get; set; }
        public int State { get; set; }
        public int Type { get; set; }
    }
}

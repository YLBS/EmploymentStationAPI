using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysPageTemplateItem
    {
        public int Pid { get; set; }
        public int? MenuId { get; set; }
        public int? ItemId { get; set; }
        public bool? Checked { get; set; }
        public short? State { get; set; }
        public int? Index { get; set; }
    }
}

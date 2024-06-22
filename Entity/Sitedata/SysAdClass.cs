using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SysAdClass
    {
        public int Id { get; set; }
        public string ClassName { get; set; } = null!;
        public int OrderId { get; set; }
        public int SiteId { get; set; }
    }
}

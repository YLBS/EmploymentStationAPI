using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SParent
    {
        public int Id { get; set; }
        public string ParentName { get; set; } = null!;
        public int OrderId { get; set; }
        public int SiteId { get; set; }
    }
}

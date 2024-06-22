using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysSection
    {
        public int SectionId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}

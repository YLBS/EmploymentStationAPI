using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysRole
    {
        public int RoleId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte Level { get; set; }
    }
}

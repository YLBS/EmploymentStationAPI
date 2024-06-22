using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewMenuInRole
    {
        public int MenuId { get; set; }
        public int RoleId { get; set; }
        public string MnuName { get; set; } = null!;
        public int ParentId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte Level { get; set; }
        public int Id { get; set; }
    }
}

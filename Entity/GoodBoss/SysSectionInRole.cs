using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysSectionInRole
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int RoleId { get; set; }
        public int Rank { get; set; }
    }
}

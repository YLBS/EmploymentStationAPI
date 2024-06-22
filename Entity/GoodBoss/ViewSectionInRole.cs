using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewSectionInRole
    {
        public int Id { get; set; }
        public int SectionId { get; set; }
        public int RoleId { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte Level { get; set; }
    }
}

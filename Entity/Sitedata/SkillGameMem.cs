using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SkillGameMem
    {
        public int? SGId { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public DateTime CreateTime { get; set; }
        public int Id { get; set; }
        public int? PosSort { get; set; }
    }
}

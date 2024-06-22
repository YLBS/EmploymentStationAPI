using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SkillGameMy
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime SignDateTime { get; set; }
        public int PosId { get; set; }
        public string JobFunction { get; set; } = null!;
        public string PosIdString { get; set; } = null!;
        public int? SGId { get; set; }
    }
}

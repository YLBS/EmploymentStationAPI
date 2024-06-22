using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemNewsInterFace
    {
        public int InviteId { get; set; }
        public int MemId { get; set; }
        public string InviteTite { get; set; } = null!;
        public int DayCount { get; set; }
        public string Noon { get; set; } = null!;
        public string TimeString { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public int ContactType { get; set; }
        public string ContactTel { get; set; } = null!;
        public string InviteMemo { get; set; } = null!;
        public bool IsFace { get; set; }
    }
}

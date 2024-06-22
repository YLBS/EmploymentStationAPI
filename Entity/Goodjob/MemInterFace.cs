using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemInterFace
    {
        public int InviteId { get; set; }
        public int MemId { get; set; }
        public string InviteTite { get; set; } = null!;
        public string InviteMemo { get; set; } = null!;
        public bool IsFace { get; set; }
        public string WxInterviewName { get; set; } = null!;
        public string WxInterviewPhone { get; set; } = null!;
        public string WxInterviewCompany { get; set; } = null!;
        public string WxInterviewDate { get; set; } = null!;
        public string WxInterviewAdress { get; set; } = null!;
        public bool WxIsActive { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}

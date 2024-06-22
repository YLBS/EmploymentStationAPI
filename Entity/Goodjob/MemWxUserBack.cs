using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemWxUserBack
    {
        public int HrWxId { get; set; }
        public int MemId { get; set; }
        public string WxOpenId { get; set; } = null!;
        public string NickName { get; set; } = null!;
        public int Sex { get; set; }
        public string HeadPortrait { get; set; } = null!;
        public bool IsMain { get; set; }
        public bool IsReceive { get; set; }
    }
}

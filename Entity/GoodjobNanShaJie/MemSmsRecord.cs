using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemSmsRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserid { get; set; }
        public string Phone { get; set; } = null!;
        public string SendContent { get; set; } = null!;
        public DateTime SendTime { get; set; }
    }
}

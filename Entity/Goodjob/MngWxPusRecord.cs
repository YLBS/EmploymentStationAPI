using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngWxPusRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string WxPushContext { get; set; } = null!;
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public DateTime SendDateTime { get; set; }
        public string Result { get; set; } = null!;
        public int SendType { get; set; }
        public DateTime? ResultDateTime { get; set; }
    }
}

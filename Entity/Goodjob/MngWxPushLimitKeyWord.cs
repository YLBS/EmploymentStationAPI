using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngWxPushLimitKeyWord
    {
        public int Id { get; set; }
        public int WxPlid { get; set; }
        public string KeyWords { get; set; } = null!;
        public string KeyWord { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ForumMessageBak
    {
        public int MsgId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string ReplyMan { get; set; } = null!;
        public DateTime? ReplyLastTime { get; set; }
        public string MsgTitle { get; set; } = null!;
        public string MsgContent { get; set; } = null!;
        public DateTime InTime { get; set; }
        public string InIp { get; set; } = null!;
        public int MsgHit { get; set; }
        public int? ReplyHit { get; set; }
        public int PlateId { get; set; }
        public int IsPass { get; set; }
        public byte? MessType { get; set; }
        public int? ThisMark { get; set; }
    }
}

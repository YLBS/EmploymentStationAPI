using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ForumComment
    {
        public int Id { get; set; }
        public int MsgId { get; set; }
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public string ReplyMessage { get; set; } = null!;
        public string InIp { get; set; } = null!;
        public DateTime? InTime { get; set; }
        public bool? IsBest { get; set; }
        public string? ReferMessage { get; set; }
        public int? CommentId { get; set; }
        public int? CommentCount { get; set; }
    }
}

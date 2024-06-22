using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewForumComment
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
        public string UserName { get; set; } = null!;
        public string ReplyMan { get; set; } = null!;
        public string MsgTitle { get; set; } = null!;
        public int MsgHit { get; set; }
        public int? ReplyHit { get; set; }
        public int IsPass { get; set; }
        public int PlateId { get; set; }
        public byte? MessType { get; set; }
        public string MsgContent { get; set; } = null!;
        public int? PosId { get; set; }
        public string? PosName { get; set; }
        public int? CommentId { get; set; }
        public string Picture { get; set; } = null!;
        public int? CommentCount { get; set; }
        public byte? Type { get; set; }
    }
}

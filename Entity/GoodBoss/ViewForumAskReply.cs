using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewForumAskReply
    {
        public int Id { get; set; }
        public int? AskId { get; set; }
        public string? Remark { get; set; }
        public int? EplId { get; set; }
        public string? EplName { get; set; }
        public DateTime? InTime { get; set; }
        public int? ReplyId { get; set; }
    }
}

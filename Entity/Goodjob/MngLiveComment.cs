using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLiveComment
    {
        public int Id { get; set; }
        public string CommContent { get; set; } = null!;
        public int MyUserId { get; set; }
        public int LiveId { get; set; }
        public DateTime CommTime { get; set; }
        public bool IsDell { get; set; }
        public DateTime? DellTime { get; set; }
        public string? AdminName { get; set; }
        public string CommentKey { get; set; } = null!;
    }
}

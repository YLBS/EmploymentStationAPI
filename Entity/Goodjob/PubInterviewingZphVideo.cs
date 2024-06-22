using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubInterviewingZphVideo
    {
        public int Id { get; set; }
        public int ZphId { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 用户是否同意状态 1同意 2 拒绝
        /// </summary>
        public int MyUserState { get; set; }
        /// <summary>
        /// 企业是否同意状态
        /// </summary>
        public int MemState { get; set; }
        public int InviteCount { get; set; }
        public int PubApplyZphId { get; set; }
        public DateTime? PubApplyZphTime { get; set; }
        public DateTime? MyUserStateUpTime { get; set; }
    }
}

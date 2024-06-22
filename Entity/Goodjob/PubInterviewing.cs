using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubInterviewing
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public int InviteCount { get; set; }
        public DateTime InviteDate { get; set; }
        public byte MemFlag { get; set; }
        /// <summary>
        /// 4 拒绝 3接受 0默认 1未读 2已读
        /// </summary>
        public byte PerFlag { get; set; }
        /// <summary>
        /// 1 被放鸽子; 2面试通过; 5 已发offer;3 淘汰/放弃;4结果待定
        /// </summary>
        public byte ResultFlag { get; set; }
        public DateTime MemTime { get; set; }
        public DateTime PerTime { get; set; }
        public string InviteMemo { get; set; } = null!;
        public DateTime? InterviewTime { get; set; }
        public string InterviewTimeType { get; set; } = null!;
        /// <summary>
        /// 录用拒绝理由，默认为null
        /// </summary>
        public string? MyRefuseReason { get; set; }
        /// <summary>
        /// 1 未读； 2 已读待确认；3 已读已确认 ；4 已读已拒绝 
        /// </summary>
        public byte MyResultFlag { get; set; }
        /// <summary>
        /// 企业面试结果确定时间
        /// </summary>
        public DateTime? ResultTime { get; set; }
        /// <summary>
        /// 个人面试结果反馈时间
        /// </summary>
        public DateTime? MyResultTime { get; set; }
        /// <summary>
        /// 录用通知书详情
        /// </summary>
        public int OfferLetterId { get; set; }
    }
}

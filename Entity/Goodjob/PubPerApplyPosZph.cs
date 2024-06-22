using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubPerApplyPosZph
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public int ReceiveCount { get; set; }
        public DateTime ReceiveDate { get; set; }
        public bool MemFlag { get; set; }
        public bool PerFlag { get; set; }
        public DateTime MemTime { get; set; }
        public DateTime PerTime { get; set; }
        /// <summary>
        /// 2为应聘 3为咨询
        /// </summary>
        public int ApplyType { get; set; }
        public int StateId { get; set; }
        public bool IsVideo { get; set; }
        public DateTime VideoDate { get; set; }
        public int VideoCount { get; set; }
        /// <summary>
        /// 视频面试分钟
        /// </summary>
        public decimal VideoMinute { get; set; }
        public DateTime? VideoEndDate { get; set; }
        /// <summary>
        /// 0  1;//.企业未确认（按钮显示： 待确认） 2;//企业已确认  （按钮显示：发起视频） 3;//企业已拒绝     （按钮显示:  已拒绝）
        /// </summary>
        public int VideoApplyState { get; set; }
        public DateTime? VideoBegDate { get; set; }
        /// <summary>
        /// 0 个人 1企业
        /// </summary>
        public int VideoLaunch { get; set; }
        public int CancelCount { get; set; }
        /// <summary>
        /// 会议是ID
        /// </summary>
        public string ConfrId { get; set; } = null!;
        public string VideoMinuteString { get; set; } = null!;
        public int VideoUpType { get; set; }
        public DateTime ApplyDate { get; set; }
    }
}

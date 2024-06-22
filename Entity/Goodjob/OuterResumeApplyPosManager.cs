using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class OuterResumeApplyPosManager
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public string PosName { get; set; } = null!;
        /// <summary>
        /// 发布渠道：12 boos ；13 智联 ；14 前程
        /// </summary>
        public int PublishChannel { get; set; }
        /// <summary>
        /// 账号
        /// </summary>
        public string AccountName { get; set; } = null!;
        /// <summary>
        /// 申请人
        /// </summary>
        public string ApplicantName { get; set; } = null!;
        /// <summary>
        /// 审核状态：1 待审核 ；2 已发布 ；3 已拒绝 ；4 已结束 ；
        /// </summary>
        public int CheckFlag { get; set; }
        public DateTime ApplyDate { get; set; }
        public string MemName { get; set; } = null!;
        public int AccountId { get; set; }
        public int ApplicantId { get; set; }
        /// <summary>
        /// 已上传简历数量
        /// </summary>
        public int HasUpLoadCount { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 岗位联系人
        /// </summary>
        public string ContactPerson { get; set; } = null!;
        /// <summary>
        /// 联系电话
        /// </summary>
        public string ContactPersonPhone { get; set; } = null!;
        /// <summary>
        /// 简历接收邮箱
        /// </summary>
        public string ReceiveEmail { get; set; } = null!;
        /// <summary>
        /// 是否是猎才岗位
        /// </summary>
        public bool IsHeadhuntPos { get; set; }
        /// <summary>
        /// 发布渠道名
        /// </summary>
        public string PublishChannelName { get; set; } = null!;
        public DateTime CheckDate { get; set; }
        /// <summary>
        /// 俊才网未发布的岗位信息，此时PosID为随机生成
        /// </summary>
        public string YetPublishPositionInfo { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmContactApply
    {
        public int ComId { get; set; }
        public int ApplicantId { get; set; }
        public string ApplicantName { get; set; } = null!;
        /// <summary>
        /// 申请人所在部门
        /// </summary>
        public int ApplicantDptId { get; set; }
        public DateTime ApplyDate { get; set; }
        /// <summary>
        /// 是否分配
        /// </summary>
        public int HasDistributed { get; set; }
        /// <summary>
        /// 任务接收人
        /// </summary>
        public int TaskRecipient { get; set; }
        public int IsCompleted { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPhone { get; set; }
        public string? Email { get; set; }
        public string? WxId { get; set; }
        public string? Position { get; set; }
        /// <summary>
        /// 0 无联系方式 ；1 已找到 ；2 无法找到联系方式 ； 3 无效 ；4 拒绝；
        /// </summary>
        public int HasContact { get; set; }
        public DateTime? ComplatedDate { get; set; }
        public string? PhoneZ { get; set; }
        public string? PhoneN { get; set; }
        public string? PhoneE { get; set; }
        public string? Remark { get; set; }
    }
}

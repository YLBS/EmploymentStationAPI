using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ZphModify
    {
        public int ModifyId { get; set; }
        public int SignId { get; set; }
        public int ComId { get; set; }
        public int ZhaoPinHuiId { get; set; }
        public int ModifyEplid { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string ModifyComName { get; set; } = null!;
        /// <summary>
        /// 联系人
        /// </summary>
        public string ModifyContact { get; set; } = null!;
        /// <summary>
        /// 电话
        /// </summary>
        public string ModifyMobile { get; set; } = null!;
        /// <summary>
        /// 审核状态 0为尚未审核  1为通过 2为尚未通过 
        /// </summary>
        public int Audit { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AuditTime { get; set; }
        /// <summary>
        /// 审核人编号
        /// </summary>
        public int AuditEplId { get; set; }
        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditDate { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }
        public string? ModifyText { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ZphSign
    {
        /// <summary>
        /// 申请编号
        /// </summary>
        public int SignId { get; set; }
        /// <summary>
        /// 申请人编号
        /// </summary>
        public int EplId { get; set; }
        /// <summary>
        /// 招聘会编号
        /// </summary>
        public int ZhaoPinHuiId { get; set; }
        /// <summary>
        /// 企业编号
        /// </summary>
        public int ComId { get; set; }
        /// <summary>
        /// 摊位号
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// 企业名称
        /// </summary>
        public string ComName { get; set; } = null!;
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; } = null!;
        /// <summary>
        /// 电话
        /// </summary>
        public string Mobile { get; set; } = null!;
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
        /// 海报状态
        /// </summary>
        public int? Modify { get; set; }
        /// <summary>
        /// 海报资料
        /// </summary>
        public string ModifyText { get; set; } = null!;
        /// <summary>
        /// 修改次数
        /// </summary>
        public int ModifyCount { get; set; }
        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditDate { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }
        public int ProEplId { get; set; }
        public string? Poster { get; set; }
        /// <summary>
        /// 取消报名理由
        /// </summary>
        public string? Cancel { get; set; }
    }
}

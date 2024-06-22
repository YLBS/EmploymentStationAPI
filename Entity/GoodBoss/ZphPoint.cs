using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ZphPoint
    {
        public int PointsId { get; set; }
        /// <summary>
        /// 企业ID
        /// </summary>
        public int ComId { get; set; }
        /// <summary>
        /// 点数
        /// </summary>
        public int ZphPoints { get; set; }
        /// <summary>
        /// 说明
        /// </summary>
        public string Instructions { get; set; } = null!;
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
        public string AuditText { get; set; } = null!;
        /// <summary>
        /// 编辑时间
        /// </summary>
        public DateTime EditDate { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }
        public int EplId { get; set; }
    }
}

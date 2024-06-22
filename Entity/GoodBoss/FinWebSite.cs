using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class FinWebSite
    {
        public int Id { get; set; }
        /// <summary>
        /// 公司ID
        /// </summary>
        public int? ClientId { get; set; }
        /// <summary>
        /// 收费人ID
        /// </summary>
        public int? EplId { get; set; }
        /// <summary>
        /// 收费人姓名
        /// </summary>
        public string? EplName { get; set; }
        /// <summary>
        /// 收费人所在部门
        /// </summary>
        public int? DptId { get; set; }
        /// <summary>
        /// 费用
        /// </summary>
        public decimal? HowCost { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string? Remark { get; set; }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime? InTime { get; set; }
        /// <summary>
        /// 管理人ID
        /// </summary>
        public int? AdminUser { get; set; }
        /// <summary>
        /// 管理人姓名
        /// </summary>
        public string? AdminName { get; set; }
        /// <summary>
        /// 管理人IP
        /// </summary>
        public string? AdminIp { get; set; }
        /// <summary>
        /// 收费性质
        /// </summary>
        public int? FinProperty { get; set; }
    }
}

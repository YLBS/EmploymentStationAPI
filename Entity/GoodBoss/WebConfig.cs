using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class WebConfig
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 网站名称
        /// </summary>
        public string? WebName { get; set; }
        /// <summary>
        /// 业绩部门显示
        /// </summary>
        public string? EffectDepart { get; set; }
        /// <summary>
        /// 特列排名显示人员
        /// </summary>
        public string? SpecialStaff { get; set; }
        /// <summary>
        /// 业务部门[控制350家等等]
        /// </summary>
        public string? BusinessDepart { get; set; }
        /// <summary>
        /// 业务员的企业数目,配合前部门来使用
        /// </summary>
        public int? CompanyCount { get; set; }
        /// <summary>
        /// 陈列期，放弃后多少个小时不能获取
        /// </summary>
        public int? HowTimeGet { get; set; }
        /// <summary>
        /// 未收费类型
        /// </summary>
        public string? MyCustomersType { get; set; }
        public int? WebCompanyNumber { get; set; }
        public DateTime? PhoneMaxTime { get; set; }
        public DateTime? PhoneMaxFileTime { get; set; }
        public int? SaleAss { get; set; }
        public string? FsEffectDepart { get; set; }
        public string? PyEffectDepart { get; set; }
    }
}

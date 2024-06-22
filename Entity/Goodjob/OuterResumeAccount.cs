using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class OuterResumeAccount
    {
        public int Id { get; set; }
        /// <summary>
        /// 账号名称
        /// </summary>
        public string AccountName { get; set; } = null!;
        /// <summary>
        /// 状态：0 正常 ；1 已过期 ；-1 冻结
        /// </summary>
        public int Status { get; set; }
        public string ResponsiblePerson { get; set; } = null!;
        public string BindPhone { get; set; } = null!;
        /// <summary>
        /// 到期时间
        /// </summary>
        public DateTime ExpiryDate { get; set; }
        public int PosCount { get; set; }
        public int PulishedPosCount { get; set; }
        public int RemainingPosCount { get; set; }
        /// <summary>
        /// 网站ID
        /// </summary>
        public int SiteId { get; set; }
        /// <summary>
        /// 所属行业
        /// </summary>
        public string BelongCalling { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        /// <summary>
        /// 管理人员Id
        /// </summary>
        public int ManagerId { get; set; }
        /// <summary>
        /// 开户负责人
        /// </summary>
        public int CreatorId { get; set; }
        /// <summary>
        /// 网站名称
        /// </summary>
        public string SiteName { get; set; } = null!;
        public int PendingPosCount { get; set; }
        /// <summary>
        /// 所属公司
        /// </summary>
        public string BelongCompany { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    /// <summary>
    /// 登录错误超过五次锁定记录
    /// </summary>
    public partial class IpLogInBlocked
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public string Ip { get; set; } = null!;
        /// <summary>
        /// 账号类型 1 企业 ；2 个人
        /// </summary>
        public int AccountType { get; set; }
        /// <summary>
        /// 封禁时间
        /// </summary>
        public DateTime BlockedDateTime { get; set; }
    }
}

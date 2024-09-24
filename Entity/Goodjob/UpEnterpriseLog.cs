using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class UpEnterpriseLog
    {
        public int Id { get; set; }
        /// <summary>
        /// 修改人的账号名称
        /// </summary>
        public string Name { get; set; } = null!;
        public int MemId { get; set; }
        /// <summary>
        /// 修改类型，1 是修改了企业信息，2是修改了企业的账号密码
        /// </summary>
        public int UpType { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

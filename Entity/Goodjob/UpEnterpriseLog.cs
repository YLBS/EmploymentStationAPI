using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class UpEnterpriseLog
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int MemId { get; set; }
        /// <summary>
        /// 操作类型，1是修改memInfoJy，2是修改memUsers的账号密码，3是对memInfoJy进行软删除，4是对删除恢复
        /// </summary>
        public int UpType { get; set; }
        public DateTime CreateTime { get; set; }
        public int ZphAdminUserId { get; set; }
        public string MemName { get; set; } = null!;
    }
}

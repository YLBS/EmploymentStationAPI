using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemAccount
    {
        public int MemId { get; set; }
        public string AccountName { get; set; } = null!;
        public string AccountPwd { get; set; } = null!;
        public DateTime RegisterTime { get; set; }
        public DateTime? LastTime { get; set; }
        public DateTime? UpTime { get; set; }
        public int AccountSate { get; set; }
        public int JcwmemId { get; set; }
        public int PosSpot { get; set; }
        public string? WxOpenId { get; set; }
        public string? LastLoginIp { get; set; }
        /// <summary>
        /// 0 为 网页 1为APP
        /// </summary>
        public int RegisterType { get; set; }
    }
}

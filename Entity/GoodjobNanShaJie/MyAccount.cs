using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MyAccount
    {
        public int MyUserId { get; set; }
        public string AccountName { get; set; } = null!;
        public string AccountPwd { get; set; } = null!;
        public DateTime RegisterTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? LastLongTime { get; set; }
        public DateTime? UpTime { get; set; }
        public int AccountSate { get; set; }
        public string? WxOpenId { get; set; }
        public int MySpot { get; set; }
        public string? LastLoginIp { get; set; }
        public int? JcwresumeId { get; set; }
        public int RegisterType { get; set; }
    }
}

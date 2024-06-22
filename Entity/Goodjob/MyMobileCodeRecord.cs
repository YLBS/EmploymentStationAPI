using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyMobileCodeRecord
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string PhoneNum { get; set; } = null!;
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime CreateDateTime { get; set; }
        /// <summary>
        /// 过期时间
        /// </summary>
        public DateTime EndDateTime { get; set; }
        /// <summary>
        /// 涞源 1 pc 2 chiping 3 android 4 ios 34 App企业 35 PC企业
        /// </summary>
        public int? Qtype { get; set; }
        public string? IpAddress { get; set; }
        /// <summary>
        /// 1.注册 2.忘记密码 3.替换 4.绑定 5api招聘会登录 6招聘会报名短信发送短信  7 MemReg 8 MemLog 9登录
        /// </summary>
        public int? Atype { get; set; }
    }
}

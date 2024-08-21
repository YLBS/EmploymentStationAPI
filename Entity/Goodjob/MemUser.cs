using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemUser
    {
        public int MemId { get; set; }
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public DateTime RegisterDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastLoginDate { get; set; }
        public string LastLoginIp { get; set; } = null!;
        /// <summary>
        /// -2 禁止使用会员 ; -1 服务过期会员 ; 0 普通注册会员 ; 2 正式会员 ; 3 云招聘会员
        /// </summary>
        public short MemberClass { get; set; }
        public DateTime BeginValidDate { get; set; }
        public DateTime EndValidDate { get; set; }
        public int MaxPosNum { get; set; }
        public int MaxResumeNum { get; set; }
        public int DateMaxViewNum { get; set; }
        public int DateViewedNum { get; set; }
        public int SumViewedNum { get; set; }
        public int AllSumViewed { get; set; }
        public byte CheckFlag { get; set; }
        public DateTime CheckDate { get; set; }
        public int CheckUserId { get; set; }
        public int SalerUserId { get; set; }
        public string SalerUserName { get; set; } = null!;
        public string SalerTel { get; set; } = null!;
        public string SalerEmail { get; set; } = null!;
        /// <summary>
        /// 0 1 pc 2 wap 3android 4ios 5wxx 1001.前程 1002.boss 1003.58 1004.智联 1005拉钩 1006珠宝外
        /// </summary>
        public int RegisterBy { get; set; }
        public int MaxHiresNum { get; set; }
        public int SumHires { get; set; }
        public string PhoneNum { get; set; } = null!;
        public int PosNum { get; set; }
        public bool Isvideo { get; set; }
        public DateTime RequestVideoDate { get; set; }
        public bool? IsSearchResume { get; set; }
        /// <summary>
        /// 1毕业生就业网
        /// </summary>
        public int PartnerId { get; set; }
        public double Jcb { get; set; }
        public int PtposNum { get; set; }
        public int PtupdateNum { get; set; }
        /// <summary>
        /// 最大直聊点
        /// </summary>
        public int MaxChatNum { get; set; }
        public int TotalCount { get; set; }
    }
}

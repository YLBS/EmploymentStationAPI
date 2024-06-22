using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyUser
    {
        /// <summary>
        /// 个人帐号编号
        /// </summary>
        public int MyUserId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; } = null!;
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; } = null!;
        /// <summary>
        /// 电子邮件地址
        /// </summary>
        public string Email { get; set; } = null!;
        /// <summary>
        /// 0=无英文简历，1=显示英文简历，2=隐藏英文简历
        /// </summary>
        public byte EngResumeFlag { get; set; }
        /// <summary>
        /// 0=简体内码，1=繁体内码			
        /// </summary>
        public byte ReceiveMailType { get; set; }
        /// <summary>
        /// 账号注册日期
        /// </summary>
        public DateTime RegisterDate { get; set; }
        /// <summary>
        /// 0=正常，1=隐藏简历，2=对指定的企业隐藏，3=待删除
        /// </summary>
        public byte ResumeStatus { get; set; }
        /// <summary>
        /// 0=公开，1=保密联系方式
        /// </summary>
        public byte ContactStatus { get; set; }
        /// <summary>
        /// 0=正试注册的(培训和教育及工作经历按表显示)，1=copy来的，按字段显示			
        /// </summary>
        public byte DisplayFlag { get; set; }
        /// <summary>
        /// 0=未完成注册，1=待审核，2=审核通过，3=审核不通过，4=更新后待复审
        /// </summary>
        public byte CheckFlag { get; set; }
        /// <summary>
        /// 注册来源
        /// </summary>
        public byte RegisterBy { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginCount { get; set; }
        /// <summary>
        /// 最后登录日期
        /// </summary>
        public DateTime LastLoginDate { get; set; }
        public int HitCount { get; set; }
        public string PhoneNum { get; set; } = null!;
        public bool IsAuPhone { get; set; }
        public bool IsAuEmail { get; set; }
        public bool IsRefresh { get; set; }
        /// <summary>
        /// 0：PC 1：触摸版 2：安卓 3：苹果 5：小程序 7百度简历 8百度小程序 9今日头条 12 支付宝小程序 14 番禺小程序 15南沙小程序 20招聘会
        /// </summary>
        public int RegisterFrom { get; set; }
        /// <summary>
        /// 简历所属 0为俊才 1为大岗 2为南沙 3为百度 4黄阁
        /// </summary>
        public int BelongType { get; set; }
        public bool Isvideo { get; set; }
        public DateTime? RequestVideoDate { get; set; }
        public int RecommendId { get; set; }
    }
}

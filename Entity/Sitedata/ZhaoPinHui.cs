using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZhaoPinHui
    {
        public int Pid { get; set; }
        public string Title { get; set; } = null!;
        public string Scale { get; set; } = null!;
        public string DateString { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string Hostunit { get; set; } = null!;
        public string Details { get; set; } = null!;
        public byte ClassType { get; set; }
        public DateTime BenigDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int HotCount { get; set; }
        public bool IsCode { get; set; }
        public string CampusTitle { get; set; } = null!;
        /// <summary>
        /// 0为正常 1为校园
        /// </summary>
        public int ZphType { get; set; }
        public string LogoPrimary { get; set; } = null!;
        public bool? IsShow { get; set; }
        public string HrLogo { get; set; } = null!;
        public string HrLogoPrimary { get; set; } = null!;
        public int AdminId { get; set; }
        public bool IsOnline { get; set; }
        public string SpecificTime { get; set; } = null!;
        public int CrmzphId { get; set; }
        public bool OnlineZph { get; set; }
        public DateTime RegEndDate { get; set; }
        public string SignRemind { get; set; } = null!;
        public int StatType { get; set; }
        public bool IsRelease { get; set; }
        public bool? IsViedo { get; set; }
        public bool? IsWebShow { get; set; }
        public int VideoBeginDate { get; set; }
        public int VideoEndDate { get; set; }
        public int JobType { get; set; }
        public int ZphAdminId { get; set; }
        /// <summary>
        /// 协办方
        /// </summary>
        public string AssistHostunit { get; set; } = null!;
        /// <summary>
        /// 承办方
        /// </summary>
        public string UndertakeHostunit { get; set; } = null!;
        /// <summary>
        /// 备注 简介 说明
        /// </summary>
        public string Remark { get; set; } = null!;
        /// <summary>
        /// 是否混合模式 线上+线下
        /// </summary>
        public bool IsBlend { get; set; }
        public int? HotCounts { get; set; }
        public string Location { get; set; } = null!;
        public string? Subscribe1 { get; set; }
        public string? Subscribe2 { get; set; }
        public string? Subscribe3 { get; set; }
        public string? Subscribe4 { get; set; }
        public bool IsSubscribe { get; set; }
        public string Display { get; set; } = null!;
        public int Price { get; set; }
        /// <summary>
        /// 0 mian fei
        /// </summary>
        public bool IsFree { get; set; }
        public bool IsSurvey { get; set; }
        public bool IsGroupCode { get; set; }
        /// <summary>
        /// 招聘会二维码群名
        /// </summary>
        public string ZphGroupName { get; set; } = null!;
        public string GroupCodePath { get; set; } = null!;
        public DateTime? CodeUpDate { get; set; }
        public bool IsLive { get; set; }
        public string LiveUrl { get; set; } = null!;
        public string LiveUrl1 { get; set; } = null!;
        /// <summary>
        /// 学生操作手册路径
        /// </summary>
        public string StudentInstructionsPath { get; set; } = null!;
        /// <summary>
        /// 企业操作手册路径
        /// </summary>
        public string MemInstructionsPath { get; set; } = null!;
        public bool IsBannerSign { get; set; }
        public bool PriceType { get; set; }
        public bool HasPopUp { get; set; }
        /// <summary>
        /// 搜索页顶部是否预告招聘会
        /// </summary>
        public bool TeaserInTop { get; set; }
    }
}

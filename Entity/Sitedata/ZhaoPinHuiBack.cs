using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZhaoPinHuiBack
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
    }
}

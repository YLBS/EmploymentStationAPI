using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class OuterResumeResume
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        /// <summary>
        /// 来源网站：12 boos ；13 智联 ；14 前程
        /// </summary>
        public int Source { get; set; }
        public DateTime InputDate { get; set; }
        public int ViewCount { get; set; }
        public int DownloadCount { get; set; }
        /// <summary>
        /// 推介数
        /// </summary>
        public int PushCount { get; set; }
        /// <summary>
        /// 简历状态：0 正常；1 已过期 ；-1 冻结
        /// </summary>
        public int ResumeStatus { get; set; }
        public string ResumeTitle { get; set; } = null!;
        public string SourceName { get; set; } = null!;
    }
}

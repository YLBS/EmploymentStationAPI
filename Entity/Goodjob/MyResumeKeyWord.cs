using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    /// <summary>
    /// 个人简历关键词
    /// </summary>
    public partial class MyResumeKeyWord
    {
        public int MyUserId { get; set; }
        /// <summary>
        /// 工作内容
        /// </summary>
        public string JobDescription { get; set; } = null!;
        /// <summary>
        /// 个人优势
        /// </summary>
        public string IndividualStrengths { get; set; } = null!;
        /// <summary>
        /// 主修课程
        /// </summary>
        public string Major { get; set; } = null!;
        /// <summary>
        /// 技能证书
        /// </summary>
        public string Certification { get; set; } = null!;
        /// <summary>
        /// 新增时间
        /// </summary>
        public DateTime AddDate { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate { get; set; }
        /// <summary>
        /// 无对应匹配岗位
        /// </summary>
        public bool NoMatch { get; set; }
    }
}

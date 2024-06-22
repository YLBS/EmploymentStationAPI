using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemOfferLetterTmepate
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public string PosName { get; set; } = null!;
        /// <summary>
        /// 公司地址
        /// </summary>
        public string MemAddress { get; set; } = null!;
        /// <summary>
        /// 联系方式
        /// </summary>
        public string ContactInfo { get; set; } = null!;
        public string OfferMidleContent { get; set; } = null!;
        /// <summary>
        /// 薪资信息
        /// </summary>
        public string Salary { get; set; } = null!;
        /// <summary>
        /// 工作时间
        /// </summary>
        public string WorkHours { get; set; } = null!;
        /// <summary>
        /// 模板名
        /// </summary>
        public string TempName { get; set; } = null!;
    }
}

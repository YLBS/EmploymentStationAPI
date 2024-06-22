using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemAdvantage
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 企业优势关键词类别：1 融资情况；2 公司亮点；3 公司实力
        /// </summary>
        public int AdvantageType { get; set; }
        public int AdvantageId { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddTime { get; set; }
    }
}

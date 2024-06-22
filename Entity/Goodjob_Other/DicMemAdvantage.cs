using System;
using System.Collections.Generic;

namespace Entity.Goodjob_Other
{
    public partial class DicMemAdvantage
    {
        public int Id { get; set; }
        /// <summary>
        /// 企业优势关键词类别：1 融资情况；2 公司亮点；3 公司实力
        /// </summary>
        public int AdvantageType { get; set; }
        /// <summary>
        /// 对应关键词
        /// </summary>
        public string AdvantageWord { get; set; } = null!;
    }
}

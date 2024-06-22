using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphConfereePo
    {
        public int StatisticsId { get; set; }
        public int Pid { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int ViewCount { get; set; }
        public int ApplyCount { get; set; }
        public int SeekCount { get; set; }
        public DateTime AddDateTime { get; set; }
        public int CandidatesNum { get; set; }
        public bool IsDell { get; set; }
        public string Reason { get; set; } = null!;
        /// <summary>
        /// 1 新增待审核  2 审核 3位通过  4 修改待审核
        /// </summary>
        public int CheckFlag { get; set; }
        public DateTime CheckDate { get; set; }
        /// <summary>
        /// 未通过 原因
        /// </summary>
        public string Region { get; set; } = null!;
    }
}

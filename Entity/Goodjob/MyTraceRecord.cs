using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyTraceRecord
    {
        public int Id { get; set; }
        /// <summary>
        /// 0全部; 1 应聘 ;2 IM消息; 3 收藏; 4游览;5系统推荐 ;6客服推介 ;  7兼职应聘
        /// </summary>
        public int TraceType { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        /// <summary>
        /// getdate()
        /// </summary>
        public DateTime TraceDate { get; set; }
        public int MyUserId { get; set; }
        /// <summary>
        /// 0未读,1未筛选,2通过,3不通过,4待定,5放入了人才库中,6删除
        /// </summary>
        public int MemFlag { get; set; }
        public int TraceId { get; set; }
        public string TraceTable { get; set; } = null!;
        public int TagFlag { get; set; }
        public int SendIm { get; set; }
        public bool IsDell { get; set; }
    }
}

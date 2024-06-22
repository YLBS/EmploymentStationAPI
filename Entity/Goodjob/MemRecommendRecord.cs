using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemRecommendRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int RecommendEplId { get; set; }
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 会员状态
        /// </summary>
        public int MemState { get; set; }
    }
}

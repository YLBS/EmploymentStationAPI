using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class RecommendedRecord
    {
        public int Id { get; set; }
        public bool IsUnsubscribe { get; set; }
        public DateTime RecommendDate { get; set; }
        public int RecommendTimes { get; set; }
        /// <summary>
        /// 数据类型，1为企业，2为个人
        /// </summary>
        public int Type { get; set; }
    }
}

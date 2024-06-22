using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphBoardDataList
    {
        public int Id { get; set; }
        /// <summary>
        /// 0 :学生专业分布 1:岗位供需对比 2 :岗位薪资分布
        /// </summary>
        public int ListType { get; set; }
        public int PId { get; set; }
        public string StringName { get; set; } = null!;
        public int Count { get; set; }
        public int MemCount { get; set; }
        public int Switch { get; set; }
    }
}

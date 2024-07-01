using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    /// <summary>
    /// 存储登记失业标签
    /// </summary>
    public partial class RegisterSign
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        /// <summary>
        /// 1 失业人员 2 退伍军人
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 录入驿站ID
        /// </summary>
        public int Esid { get; set; }
        public DateTime? CreateTime { get; set; }
        /// <summary>
        /// 1 大岗，2 南沙，4 黄阁
        /// </summary>
        public int? BelongType { get; set; }
    }
}

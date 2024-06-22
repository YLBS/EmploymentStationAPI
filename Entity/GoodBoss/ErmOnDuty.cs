using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ErmOnDuty
    {
        public int Id { get; set; }
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public int DptId { get; set; }
        /// <summary>
        /// 值班日期
        /// </summary>
        public DateTime OnDutyDay { get; set; }
        /// <summary>
        /// 值班类型，1 全天；2  上午；3  下午 
        /// </summary>
        public byte OnDutyTime { get; set; }
        /// <summary>
        /// 插入时间
        /// </summary>
        public DateTime InputTime { get; set; }
        public string DptName { get; set; } = null!;
    }
}

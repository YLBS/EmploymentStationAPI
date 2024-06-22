using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemServiceNumber
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 职位数量
        /// </summary>
        public int PosNumber { get; set; }
        /// <summary>
        /// 简历数量
        /// </summary>
        public int ResumeNumber { get; set; }
        public DateTime? UpTime { get; set; }
        public DateTime CreatTime { get; set; }
    }
}

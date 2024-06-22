using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemPosJobFunctionTime
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        public string JobTime { get; set; } = null!;
        public string WorkTime { get; set; } = null!;
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 时间类型：11上午12下午13晚上
        /// </summary>
        public string TimeType { get; set; } = null!;
    }
}

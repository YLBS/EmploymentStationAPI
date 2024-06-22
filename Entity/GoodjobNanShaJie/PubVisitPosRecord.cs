using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class PubVisitPosRecord
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int PosId { get; set; }
        public int PosCaling { get; set; }
        public DateTime CreatTime { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 查看次数(重复查看则累加该字段)
        /// </summary>
        public int VisitCount { get; set; }
    }
}

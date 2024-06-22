using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class PubPosApplyRecord
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime ApplyTime { get; set; }
        public DateTime CreatTime { get; set; }
        public bool IsRead { get; set; }
        /// <summary>
        /// 是否签约 0否 1 是
        /// </summary>
        public bool IsContract { get; set; }
        public DateTime? ReadTime { get; set; }
        /// <summary>
        /// 1为邀约 2为拒绝
        /// </summary>
        public int ApplyState { get; set; }
    }
}

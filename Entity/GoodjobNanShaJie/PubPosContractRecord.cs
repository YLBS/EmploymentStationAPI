using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class PubPosContractRecord
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public int InvitationsId { get; set; }
        public int ApplyId { get; set; }
        public DateTime CreatTime { get; set; }
        public DateTime ContractTime { get; set; }
        /// <summary>
        /// 是否签约 0否 1 是
        /// </summary>
        public bool IsContract { get; set; }
    }
}

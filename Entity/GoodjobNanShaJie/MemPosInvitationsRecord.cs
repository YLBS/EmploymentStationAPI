using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemPosInvitationsRecord
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime InvitationsTime { get; set; }
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 是否签约 0否 1 是
        /// </summary>
        public bool IsContract { get; set; }
        public int InvitationCount { get; set; }
        public DateTime? ContractTime { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadTime { get; set; }
        public string InvitationContent { get; set; } = null!;
    }
}

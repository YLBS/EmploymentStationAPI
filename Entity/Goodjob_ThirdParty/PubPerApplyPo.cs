using System;
using System.Collections.Generic;

namespace Entity.Goodjob_ThirdParty
{
    public partial class PubPerApplyPo
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public int ReceiveCount { get; set; }
        public DateTime ReceiveDate { get; set; }
        public byte MemFlag { get; set; }
        public byte PerFlag { get; set; }
        public DateTime MemTime { get; set; }
        public DateTime PerTime { get; set; }
        public bool IsCommend { get; set; }
        public int IsXxcx { get; set; }
    }
}

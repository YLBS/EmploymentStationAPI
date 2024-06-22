using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngCommendPo
    {
        public int Id { get; set; }
        public int SalerId { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public bool IsFlag { get; set; }
        public string Feedback { get; set; } = null!;
        public DateTime CommendDate { get; set; }
        public bool Isqd { get; set; }
        public DateTime QdDate { get; set; }
        public byte FeedType { get; set; }
        public int QdType { get; set; }
    }
}

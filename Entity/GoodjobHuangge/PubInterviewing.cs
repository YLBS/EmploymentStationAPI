using System;
using System.Collections.Generic;

namespace Entity.GoodjobHuangge
{
    public partial class PubInterviewing
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public int InviteCount { get; set; }
        public DateTime InviteDate { get; set; }
        public byte MemFlag { get; set; }
        public byte PerFlag { get; set; }
        public byte ResultFlag { get; set; }
        public DateTime MemTime { get; set; }
        public DateTime PerTime { get; set; }
        public string InviteMemo { get; set; } = null!;
        public DateTime? InterviewTime { get; set; }
        public string InterviewTimeType { get; set; } = null!;
    }
}

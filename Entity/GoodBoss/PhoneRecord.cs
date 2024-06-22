using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PhoneRecord
    {
        public int Id { get; set; }
        public string Callid { get; set; } = null!;
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? CallerNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public int? TalkLength { get; set; }
        public int? EplId { get; set; }
        public int? DptId { get; set; }
        public string? EplName { get; set; }
        public int Comid { get; set; }
        public string ComName { get; set; } = null!;
        public string Voicefile { get; set; } = null!;
        public bool? IsCommend { get; set; }
        public short? CallType { get; set; }
        public string? DialKey { get; set; }
        public bool? Deleted { get; set; }
        public short? CallResult { get; set; }
        public bool? IsEval { get; set; }
    }
}

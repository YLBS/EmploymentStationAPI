using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubStraightCast
    {
        public int Id { get; set; }
        public int? MemId { get; set; }
        public int? PosId { get; set; }
        public string? Cellphone { get; set; }
        public int? ScType { get; set; }
        public DateTime? CastTime { get; set; }
        public string? Uid { get; set; }
        public bool IsVisit { get; set; }
        public bool IsInvitation { get; set; }
        public int IsDell { get; set; }
    }
}

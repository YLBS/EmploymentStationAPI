using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyVideo
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public string? Route { get; set; }
        public string? Describe { get; set; }
        public string? LongTime { get; set; }
        public bool IsOpen { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? CreateDate { get; set; }
        public string? VideoCover { get; set; }
        public string? LocalRoute { get; set; }
        public int ApprovalStauts { get; set; }
        public int Vwidth { get; set; }
        public int Vheight { get; set; }
        public string? RejectReason { get; set; }
        public int? Eid { get; set; }
    }
}

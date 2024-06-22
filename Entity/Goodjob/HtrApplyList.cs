using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class HtrApplyList
    {
        public int Id { get; set; }
        public int? MyUserId { get; set; }
        public int? MemId { get; set; }
        public int? PosId { get; set; }
        public string? ResumeTxt { get; set; }
        public DateTime? ApplyTime { get; set; }
        public string? Phone { get; set; }
        public string? MemName { get; set; }
        public string? PosName { get; set; }
        public string? WordFile { get; set; }
        public int NewsMyuserId { get; set; }
        public string ResumeContext { get; set; } = null!;
    }
}

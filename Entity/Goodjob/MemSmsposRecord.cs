using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSmsposRecord
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string? MemName { get; set; }
        public string? Phone { get; set; }
        public int ResumeCount { get; set; }
        public string? Context { get; set; }
        public DateTime? CreateTime { get; set; }
        public bool? IsSucceed { get; set; }
    }
}

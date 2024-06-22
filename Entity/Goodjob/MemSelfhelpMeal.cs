using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSelfhelpMeal
    {
        public int MemId { get; set; }
        public int ResumeCount { get; set; }
        public DateTime ResumEndTime { get; set; }
        public int PosCount { get; set; }
        public DateTime PosEndTime { get; set; }
        public int SmsCount { get; set; }
        public DateTime SmsEndTime { get; set; }
        public int UpdateCount { get; set; }
        public DateTime UpdateEndTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphAppointmentTime
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        public DateTime InterviewTime { get; set; }
        public string InterviewTimeType { get; set; } = null!;
        public int Pid { get; set; }
        public DateTime CreatTime { get; set; }
    }
}

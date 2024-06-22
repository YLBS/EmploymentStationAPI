using System;
using System.Collections.Generic;

namespace Entity.GoodjobHuangge
{
    public partial class PubLeave
    {
        public int LeaveId { get; set; }
        public string TrueName { get; set; } = null!;
        public string MobileNum { get; set; } = null!;
        public string Problem { get; set; } = null!;
        public DateTime ProblemDate { get; set; }
        public string Answer { get; set; } = null!;
        public DateTime AnswerDate { get; set; }
        public bool IsShow { get; set; }
    }
}

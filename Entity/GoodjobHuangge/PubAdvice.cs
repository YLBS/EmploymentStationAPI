using System;
using System.Collections.Generic;

namespace Entity.GoodjobHuangge
{
    public partial class PubAdvice
    {
        public int AdviceId { get; set; }
        public string TrueName { get; set; } = null!;
        public string MobileNum { get; set; } = null!;
        public bool EmploymentHelp { get; set; }
        public bool JobSuccess { get; set; }
        public string Problem { get; set; } = null!;
        public DateTime ProblemDate { get; set; }
    }
}

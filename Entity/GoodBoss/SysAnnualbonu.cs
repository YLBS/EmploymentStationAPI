using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysAnnualbonu
    {
        public int AnnualId { get; set; }
        public int DptId { get; set; }
        public int EplId { get; set; }
        public double BasicGoals { get; set; }
        public double DesiredGoals { get; set; }
        public int Year { get; set; }
    }
}

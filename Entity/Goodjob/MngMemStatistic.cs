using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngMemStatistic
    {
        public int Id { get; set; }
        public int Rstype { get; set; }
        public int Pc { get; set; }
        public int Android { get; set; }
        public int Touch { get; set; }
        public int Ios { get; set; }
        public int Xcx { get; set; }
        public DateTime StatisticsTime { get; set; }
    }
}

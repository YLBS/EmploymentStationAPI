using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngResumeStatistic
    {
        public int Id { get; set; }
        public int Rstype { get; set; }
        public int Pc { get; set; }
        public int Touch { get; set; }
        public int Android { get; set; }
        public int Ios { get; set; }
        public int Xcx { get; set; }
        public int Zph { get; set; }
        public int Bd { get; set; }
        public int Bdxcx { get; set; }
        public int Jrttxcx { get; set; }
        public int Pyxcx { get; set; }
        public int Nsxcx { get; set; }
        public DateTime StatisticsTime { get; set; }
        /// <summary>
        /// Boss录入简历量
        /// </summary>
        public int Boss { get; set; }
        /// <summary>
        /// 前程简历录入量
        /// </summary>
        public int Qc { get; set; }
        /// <summary>
        /// 智联简历录入量
        /// </summary>
        public int Zl { get; set; }
    }
}

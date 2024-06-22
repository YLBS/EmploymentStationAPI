using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmMemselfhelp
    {
        public int Id { get; set; }
        public int Comid { get; set; }
        public int Memid { get; set; }
        public int EplId { get; set; }
        public int PackageId { get; set; }
        public DateTime OpenDate { get; set; }
        public string DemoText { get; set; } = null!;
        public DateTime AddTime { get; set; }
        public int CheckState { get; set; }
        public int IsOpen { get; set; }
        public int JobCount { get; set; }
        public int ResumeCount { get; set; }
        public double Money { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmComSelf
    {
        public int ComId { get; set; }
        public int IsOpen { get; set; }
        public int CheckState { get; set; }
        public DateTime AddTime { get; set; }
        public string DemoText { get; set; } = null!;
        public DateTime OpenDate { get; set; }
        public int PackageId { get; set; }
        public int EplId { get; set; }
        public int Id { get; set; }
        public string ComName { get; set; } = null!;
        public string EplName { get; set; } = null!;
        public int Comid1 { get; set; }
        public int Memid { get; set; }
        public int JobCount { get; set; }
        public int ResumeCount { get; set; }
        public int Expr1 { get; set; }
        public int MemId1 { get; set; }
        public double Money { get; set; }
        public int DptId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmFreeOpen
    {
        public int Id { get; set; }
        public int PosNum { get; set; }
        public int ResumeNum { get; set; }
        public DateTime BeginDate { get; set; }
        public int OpenDate { get; set; }
        public byte CheckState { get; set; }
        public DateTime InputDate { get; set; }
        public int InputEplId { get; set; }
        public string ComName { get; set; } = null!;
        public int MemId { get; set; }
        public string EplName { get; set; } = null!;
        public int ComId { get; set; }
    }
}

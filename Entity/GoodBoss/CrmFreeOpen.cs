using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmFreeOpen
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int MemId { get; set; }
        public int PosNum { get; set; }
        public int ResumeNum { get; set; }
        public DateTime BeginDate { get; set; }
        public int OpenDate { get; set; }
        public DateTime CheckDate { get; set; }
        public byte CheckState { get; set; }
        public int CheckEplId { get; set; }
        public DateTime InputDate { get; set; }
        public int InputEplId { get; set; }
    }
}

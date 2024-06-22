using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmComSnsOpen
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int MemId { get; set; }
        public int MsnCount { get; set; }
        public decimal TradeMoney { get; set; }
        public string Memo { get; set; } = null!;
        public DateTime CheckDate { get; set; }
        public byte CheckState { get; set; }
        public int CheckEplId { get; set; }
        public DateTime OpenDate { get; set; }
        public int OpenState { get; set; }
        public int OpenEplId { get; set; }
        public DateTime InputDate { get; set; }
        public int InputEplId { get; set; }
        public int ApplyTypeId { get; set; }
        public string Bondno { get; set; } = null!;
    }
}

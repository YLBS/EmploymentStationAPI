using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmBlockCom
    {
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public DateTime InputDate { get; set; }
    }
}

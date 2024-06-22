using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmRemind
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public DateTime Vdate { get; set; }
        public int Sday { get; set; }
        public byte Type { get; set; }
        public DateTime CreateTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmCallAwoke
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int MemId { get; set; }
        public string ComName { get; set; } = null!;
        public int EplId { get; set; }
        public DateTime AwokeDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public short? FinishFlag { get; set; }
    }
}

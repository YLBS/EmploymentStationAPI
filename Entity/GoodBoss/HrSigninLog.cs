using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class HrSigninLog
    {
        public int Id { get; set; }
        public int Uid { get; set; }
        public DateTime Insertdate { get; set; }
        public string Fromip { get; set; } = null!;
    }
}

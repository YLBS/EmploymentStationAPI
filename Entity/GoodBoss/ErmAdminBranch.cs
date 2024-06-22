using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ErmAdminBranch
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public string? ManaBranch { get; set; }
        public DateTime? RegTime { get; set; }
    }
}

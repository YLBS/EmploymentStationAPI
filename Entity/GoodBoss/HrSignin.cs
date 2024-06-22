using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class HrSignin
    {
        public int Id { get; set; }
        public string Insertdate { get; set; } = null!;
        public int UId { get; set; }
        public string Morningtime { get; set; } = null!;
        public string Afternoontime { get; set; } = null!;
        public byte Morningbz { get; set; }
        public byte Afternoonbz { get; set; }
        public string FromIp { get; set; } = null!;
        public string FromIpLast { get; set; } = null!;
    }
}

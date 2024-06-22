using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmTempClient
    {
        public int Id { get; set; }
        public int? ComId { get; set; }
        public int? DptId { get; set; }
        public short? State { get; set; }
        public DateTime? ActiveTime { get; set; }
        public int? KeepDay { get; set; }
    }
}

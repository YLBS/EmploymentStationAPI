using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmClientType
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public short Channelid { get; set; }
        public byte? Orderid { get; set; }
        public int? Monday { get; set; }
        public int? Mcount { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PhoneCallAccept
    {
        public int PhoneId { get; set; }
        public string CallAccept { get; set; } = null!;
        public string Callnum { get; set; } = null!;
        public string Phonenum { get; set; } = null!;
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class WebSiteType
    {
        public int Id { get; set; }
        public int CsId { get; set; }
        public string CsName { get; set; } = null!;
        public bool? IsCoin { get; set; }
        public DateTime Intime { get; set; }
    }
}

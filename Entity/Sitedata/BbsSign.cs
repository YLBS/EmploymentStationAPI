using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class BbsSign
    {
        public int SignId { get; set; }
        public string ComName { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public DateTime AddDateTime { get; set; }
        public int Bbsid { get; set; }
        public bool IsSign { get; set; }
        public DateTime SignDateTime { get; set; }
    }
}

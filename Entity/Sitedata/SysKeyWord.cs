using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class SysKeyWord
    {
        public int Id { get; set; }
        public int PosTypeId { get; set; }
        public string KeyWords { get; set; } = null!;
        public string KeyHome { get; set; } = null!;
        public DateTime AddTime { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusNmem
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int CampusId { get; set; }
        public string OpenId { get; set; } = null!;
        public DateTime AddDateTime { get; set; }
    }
}

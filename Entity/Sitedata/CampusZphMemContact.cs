using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusZphMemContact
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string ContactPerson { get; set; } = null!;
        public string ContactPhone { get; set; } = null!;
        public DateTime AddDateTime { get; set; }
        public int CampusZpId { get; set; }
    }
}

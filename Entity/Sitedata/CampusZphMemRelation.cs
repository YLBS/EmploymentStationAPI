using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusZphMemRelation
    {
        public int Id { get; set; }
        public int CampusId { get; set; }
        public int MemId { get; set; }
        public string OpenId { get; set; } = null!;
        public DateTime AddDatetime { get; set; }
        public int UserId { get; set; }
    }
}

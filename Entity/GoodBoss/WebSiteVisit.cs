using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class WebSiteVisit
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? VisitType { get; set; }
        public string? VisitInfo { get; set; }
        public int? VisitUser { get; set; }
        public DateTime? InTime { get; set; }
    }
}

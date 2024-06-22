using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphCheckTemplate
    {
        public int Id { get; set; }
        public int ZphAdminId { get; set; }
        public string Reason { get; set; } = null!;
        public bool IsDell { get; set; }
        public DateTime CreatDate { get; set; }
        public DateTime? DellDate { get; set; }
    }
}

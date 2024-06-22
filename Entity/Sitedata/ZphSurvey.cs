using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphSurvey
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int Pid { get; set; }
        public string Survey1 { get; set; } = null!;
        public string Survey2 { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngAd
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Remark { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string Url { get; set; } = null!;
        public int ClassId { get; set; }
        public bool IsFlash { get; set; }
        public string MemId { get; set; } = null!;
        public int VisitCount { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime BeginDate { get; set; }
        public int ValidDay { get; set; }
        public int TopValue { get; set; }
        public int AddressP { get; set; }
        public int AddressC { get; set; }
        public string AreaSite { get; set; } = null!;
        public string PartnerSite { get; set; } = null!;
        public string PopSite { get; set; } = null!;
        public bool Disabled { get; set; }
        public string DevelopSite { get; set; } = null!;
        public int SpaceCount { get; set; }
    }
}

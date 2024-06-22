using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusZpPo
    {
        public int Id { get; set; }
        public string PosName { get; set; } = null!;
        public string PosJobId { get; set; } = null!;
        public string PosJobBigId { get; set; } = null!;
        public int Pnumber { get; set; }
        public int MemId { get; set; }
        public string Posdecription { get; set; } = null!;
        public DateTime AddDateTime { get; set; }
        public string PosJobValue { get; set; } = null!;
        public int CampusZpId { get; set; }
        public DateTime? UpdateDateTime { get; set; }
        public int PosSalaryId { get; set; }
        public string PosSalaryRange { get; set; } = null!;
        public int TemplateId { get; set; }
        public int UserId { get; set; }
        public int Audit { get; set; }
    }
}

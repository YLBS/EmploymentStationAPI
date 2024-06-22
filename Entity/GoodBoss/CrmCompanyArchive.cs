using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmCompanyArchive
    {
        public int CaId { get; set; }
        public int ComId { get; set; }
        public string ComName { get; set; } = null!;
        public int? CsId { get; set; }
        public int CasId { get; set; }
        public int CasParentId { get; set; }
        public string CaName { get; set; } = null!;
        public string CaType { get; set; } = null!;
        public int CaSize { get; set; }
        public string CaLnkUrl { get; set; } = null!;
        public DateTime UploadDate { get; set; }
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public string EplIp { get; set; } = null!;
        public bool DelFlag { get; set; }
        public int? Caflag { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmAbnegateLog
    {
        public DateTime AngDate { get; set; }
        public int EplId { get; set; }
        public string Reason { get; set; } = null!;
        public int AngId { get; set; }
        public int ComId { get; set; }
        public int Id { get; set; }
        public string AngName { get; set; } = null!;
        public int MemId { get; set; }
        public string KeyWord { get; set; } = null!;
        public string ComName { get; set; } = null!;
        public string HomePage { get; set; } = null!;
        public string Info { get; set; } = null!;
        public string PhoneZ { get; set; } = null!;
        public string PhoneN { get; set; } = null!;
        public string PhoneE { get; set; } = null!;
        public string FaxZ { get; set; } = null!;
        public string FaxN { get; set; } = null!;
        public string FaxE { get; set; } = null!;
        public int Callings { get; set; }
        public int ProvId { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public int CsId { get; set; }
        public int SourceId { get; set; }
        public int Source { get; set; }
        public int OCsId { get; set; }
        public string Jobs { get; set; } = null!;
        public DateTime? LastLinkDate { get; set; }
        public int DevelopStatus { get; set; }
        public DateTime RegisterDate { get; set; }
        public string? Cemail { get; set; }
        public string? Cbankroll { get; set; }
        public DateTime? Cregtime { get; set; }
        public DateTime? JcwRegTime { get; set; }
        public DateTime? Cgetdate { get; set; }
        public string? Cposition { get; set; }
        public short? Clicence { get; set; }
        public DateTime? Cstime { get; set; }
        public DateTime? Cetime { get; set; }
        public DateTime? CabandonTime { get; set; }
        public int FinId { get; set; }
        public string EplName { get; set; } = null!;
        public int DptId { get; set; }
    }
}

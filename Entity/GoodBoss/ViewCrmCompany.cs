using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmCompany
    {
        public int ComId { get; set; }
        public int EplId { get; set; }
        public int MemId { get; set; }
        public string ComName { get; set; } = null!;
        public string KeyWord { get; set; } = null!;
        public string HomePage { get; set; } = null!;
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
        public string? EplName { get; set; }
        public int? DptId { get; set; }
        public int? EsId { get; set; }
        public string? Pname { get; set; }
        public string? CityName { get; set; }
        public string? CsName { get; set; }
        public int OCsId { get; set; }
        public int? DepartId { get; set; }
        public int? CurveId { get; set; }
        public int? CurveSequence { get; set; }
        public DateTime? CurveStartTime { get; set; }
        public DateTime? WakeTime { get; set; }
        public bool? IsLastCurve { get; set; }
        public int? CurveValue { get; set; }
        public int? CurrentValue { get; set; }
        public int? CollId { get; set; }
        public string? CollEplName { get; set; }
        public bool? CollState { get; set; }
        public DateTime? CessionDate { get; set; }
        public int? CollEplId { get; set; }
        public int TownId { get; set; }
        public DateTime? OuterRefleshDate { get; set; }
        public string? FromSite { get; set; }
        public string? OuterSiteUrl { get; set; }
        public string Info { get; set; } = null!;
        public string Jobs { get; set; } = null!;
    }
}

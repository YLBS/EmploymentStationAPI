using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmCompanyOld
    {
        public int ComId { get; set; }
        public int EplId { get; set; }
        public int? DepartId { get; set; }
        public int MemId { get; set; }
        public string ComName { get; set; } = null!;
        public string KeyWord { get; set; } = null!;
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
        public int TownId { get; set; }
        public string Address { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public int CsId { get; set; }
        public int SourceId { get; set; }
        public int Source { get; set; }
        public string Jobs { get; set; } = null!;
        public int OCsId { get; set; }
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
        public DateTime? CessionDate { get; set; }
        public int? CurveId { get; set; }
        public int? CurveSequence { get; set; }
        public DateTime? CurveStartTime { get; set; }
        public bool? IsLastCurve { get; set; }
        public int? CurveValue { get; set; }
        public int? CurrentValue { get; set; }
        public int? CollId { get; set; }
        public int? CollEplId { get; set; }
        public string? CollEplName { get; set; }
        public bool? CollState { get; set; }
        public int? Cs80State { get; set; }
        public DateTime? DepartmentTime { get; set; }
        public string HrQq { get; set; } = null!;
        public int JiufuMemId { get; set; }
        public int ZphPoints { get; set; }
    }
}

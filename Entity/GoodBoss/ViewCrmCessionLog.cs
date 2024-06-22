using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmCessionLog
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int FEplId { get; set; }
        public int TEplId { get; set; }
        public string CessionReason { get; set; } = null!;
        public int FCsId { get; set; }
        public int? TCsId { get; set; }
        public DateTime CessionDate { get; set; }
        public int Status { get; set; }
        public string InceptReason { get; set; } = null!;
        public DateTime? InceptDate { get; set; }
        public DateTime RegisterDate { get; set; }
        public int? AdminUid { get; set; }
        public string? AdminIp { get; set; }
        public int? EplId { get; set; }
        public int? DepartId { get; set; }
        public int? MemId { get; set; }
        public string? ComName { get; set; }
        public string? KeyWord { get; set; }
        public string? HomePage { get; set; }
        public string? Info { get; set; }
        public string? PhoneZ { get; set; }
        public string? PhoneN { get; set; }
        public string? PhoneE { get; set; }
        public string? FaxZ { get; set; }
        public string? FaxN { get; set; }
        public string? FaxE { get; set; }
        public int? Callings { get; set; }
        public int? ProvId { get; set; }
        public int? CityId { get; set; }
        public string? Address { get; set; }
        public string? PostCode { get; set; }
        public int? CsId { get; set; }
        public int? SourceId { get; set; }
        public int? Source { get; set; }
        public string? Jobs { get; set; }
        public int? OCsId { get; set; }
        public DateTime? LastLinkDate { get; set; }
        public int? DevelopStatus { get; set; }
        public DateTime? Expr1 { get; set; }
        public string? Cbankroll { get; set; }
        public string? Cemail { get; set; }
        public DateTime? JcwRegTime { get; set; }
        public DateTime? Cgetdate { get; set; }
        public DateTime? Cregtime { get; set; }
        public string? Cposition { get; set; }
        public short? Clicence { get; set; }
        public DateTime? Cstime { get; set; }
        public DateTime? Cetime { get; set; }
        public DateTime? CabandonTime { get; set; }
        public int? FinId { get; set; }
        public string? FUserName { get; set; }
        public string? FCsName { get; set; }
        public string? FEplname { get; set; }
        public string StatusValue { get; set; } = null!;
        public string TEplname { get; set; } = null!;
        public string AdminEplName { get; set; } = null!;
        public int DptId { get; set; }
    }
}

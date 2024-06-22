using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmClient
    {
        public int ComId { get; set; }
        public int EplId { get; set; }
        public int? DptId { get; set; }
        public string? EplName { get; set; }
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
        public string Address { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public int CsId { get; set; }
        public string? CsName { get; set; }
        public string? Source { get; set; }
        public string Jobs { get; set; } = null!;
        public int OCsId { get; set; }
        public DateTime? LastLinkDate { get; set; }
        public int DevelopStatus { get; set; }
        public string? RegisterDate { get; set; }
        public string? Cemail { get; set; }
        public string? Cbankroll { get; set; }
        public string? Cregtime { get; set; }
        public string? Cgetdate { get; set; }
        public string? Cposition { get; set; }
        public short? Clicence { get; set; }
        public string? Cstime { get; set; }
        public string? Cetime { get; set; }
        public string? CabandonTime { get; set; }
        public string? Pname { get; set; }
        public string? Cityname { get; set; }
        public string Ctel { get; set; } = null!;
        public decimal? TraTradeMoney { get; set; }
        public decimal? TraReceiveMoney { get; set; }
        public string? TraInfo { get; set; }
        public byte? TraReceiveFlag { get; set; }
        public int? TraTradeEplId { get; set; }
        public DateTime? TraTradeDate { get; set; }
        public int? TraReceiveEplId { get; set; }
        public DateTime? TraReceiveDate { get; set; }
        public DateTime? TraInputDate { get; set; }
        public int SourceId { get; set; }
        public int Expr1 { get; set; }
        public DateTime Expr2 { get; set; }
        public DateTime? Expr3 { get; set; }
        public DateTime? JcwRegTime { get; set; }
        public DateTime? Expr4 { get; set; }
        public DateTime? Expr5 { get; set; }
        public DateTime? Expr6 { get; set; }
        public DateTime? Expr7 { get; set; }
        public int FinId { get; set; }
        public int? Cs80State { get; set; }
        public DateTime? DepartmentTime { get; set; }
        public int TownId { get; set; }
        public string? NewsCsName { get; set; }
        public DateTime? OuterRefleshDate { get; set; }
        public string? FromSite { get; set; }
        public string? OuterSiteUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmTransaction
    {
        public int Id { get; set; }
        public byte OpenType { get; set; }
        public string Bondid { get; set; } = null!;
        public int ComId { get; set; }
        public int MemId { get; set; }
        public int PosNum { get; set; }
        public string? BeginDate { get; set; }
        public string? EndDate { get; set; }
        public int ResumeNum { get; set; }
        public int OpenEplId { get; set; }
        public int InputEplId { get; set; }
        public string ComName { get; set; } = null!;
        public string Memo { get; set; } = null!;
        public DateTime CheckDate { get; set; }
        public byte CheckState { get; set; }
        public int CheckEplId { get; set; }
        public DateTime OpenDate { get; set; }
        public byte OpenState { get; set; }
        public DateTime InputDate { get; set; }
        public int EplId { get; set; }
        public string KeyWord { get; set; } = null!;
        public string HomePage { get; set; } = null!;
        public int Expr1 { get; set; }
        public string Info { get; set; } = null!;
        public string PhoneZ { get; set; } = null!;
        public string PhoneN { get; set; } = null!;
        public string FaxZ { get; set; } = null!;
        public string PhoneE { get; set; } = null!;
        public string FaxN { get; set; } = null!;
        public string FaxE { get; set; } = null!;
        public int Callings { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; } = null!;
        public string PostCode { get; set; } = null!;
        public int ProvId { get; set; }
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
        public DateTime? Cstime { get; set; }
        public short? Clicence { get; set; }
        public DateTime? Cetime { get; set; }
        public DateTime? CabandonTime { get; set; }
        public int FinId { get; set; }
        public decimal? ReceiveMoney { get; set; }
        public decimal? TradeMoney { get; set; }
    }
}

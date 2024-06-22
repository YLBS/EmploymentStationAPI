using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewFinTradeList
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public int DptId { get; set; }
        public decimal? TradeMoney { get; set; }
        public decimal? ReceiveMoney { get; set; }
        public string? Info { get; set; }
        public byte ReceiveFlag { get; set; }
        public int TradeEplId { get; set; }
        public DateTime TradeDate { get; set; }
        public int ReceiveEplId { get; set; }
        public DateTime ReceiveDate { get; set; }
        public DateTime InputDate { get; set; }
        public string ComName { get; set; } = null!;
        public string? DptName { get; set; }
        public int MemId { get; set; }
        public string KeyWord { get; set; } = null!;
        public string HomePage { get; set; } = null!;
        public string ComInfo { get; set; } = null!;
        public string PhoneZ { get; set; } = null!;
        public string PhoneN { get; set; } = null!;
        public string PhoneE { get; set; } = null!;
        public string FaxZ { get; set; } = null!;
        public string FaxN { get; set; } = null!;
        public string FaxE { get; set; } = null!;
        public int Callings { get; set; }
        public int CityId { get; set; }
        public int ProvId { get; set; }
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
        public string? Cstime { get; set; }
        public string? Cetime { get; set; }
        public DateTime? CabandonTime { get; set; }
        public int FinId { get; set; }
        public string EplName { get; set; } = null!;
        public string? Picture { get; set; }
        public int Percount { get; set; }
        public int Persum { get; set; }
        public short NewType { get; set; }
        public short? Expr1 { get; set; }
        public bool DelFlag { get; set; }
        public int? OtherFinId { get; set; }
    }
}

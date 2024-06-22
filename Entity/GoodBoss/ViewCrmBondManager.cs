using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmBondManager
    {
        public int Id { get; set; }
        public string Bondno { get; set; } = null!;
        public int ComId { get; set; }
        public decimal? Bdmoney { get; set; }
        public string? BeginDate { get; set; }
        public string? EndDate { get; set; }
        public string Memo { get; set; } = null!;
        public byte CheckState { get; set; }
        public string WordFile { get; set; } = null!;
        public int CheckEplId { get; set; }
        public DateTime CheckDate { get; set; }
        public string CheckMemo { get; set; } = null!;
        public DateTime InputDate { get; set; }
        public int InputEplId { get; set; }
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
        public string? Cstime { get; set; }
        public string? Cetime { get; set; }
        public DateTime? CabandonTime { get; set; }
        public int FinId { get; set; }
        public int PostNum { get; set; }
        public int ResumeNum { get; set; }
        public bool IsAd { get; set; }
        public string IsAdValue { get; set; } = null!;
        public string? EplName { get; set; }
        public string? UserName { get; set; }
        public int? DptId { get; set; }
        public bool IsOpenUseed { get; set; }
        public DateTime? AdEnd { get; set; }
        public DateTime? AdBegin { get; set; }
        public int? Adlocation { get; set; }
        public int AdRecordId { get; set; }
        public string? AdInfo { get; set; }
        public int? Expr1 { get; set; }
        public bool Expr2 { get; set; }
        public bool HasPage { get; set; }
        public int SmsCount { get; set; }
        public decimal SmsAmount { get; set; }
        public int ZhaoPinHuiCount { get; set; }
        public int ContractMonth { get; set; }
        public int OrderStatus { get; set; }
        public int PartTimePositoin { get; set; }
        public int ReflashCount { get; set; }
    }
}

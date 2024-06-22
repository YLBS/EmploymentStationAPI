using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmBondManager
    {
        public int Id { get; set; }
        public string Bondno { get; set; } = null!;
        public int ComId { get; set; }
        public decimal Bdmoney { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PostNum { get; set; }
        public int ResumeNum { get; set; }
        public bool IsAd { get; set; }
        public string Memo { get; set; } = null!;
        public string WordFile { get; set; } = null!;
        public byte CheckState { get; set; }
        public int CheckEplId { get; set; }
        public DateTime CheckDate { get; set; }
        public string CheckMemo { get; set; } = null!;
        public DateTime InputDate { get; set; }
        public int InputEplId { get; set; }
        public bool IsOpenUseed { get; set; }
        public int? Adlocation { get; set; }
        public DateTime? AdBegin { get; set; }
        public DateTime? AdEnd { get; set; }
        public int? AdRecordId { get; set; }
        public string? AdInfo { get; set; }
        public bool HasPage { get; set; }
        public int SmsCount { get; set; }
        public decimal SmsAmount { get; set; }
        public int ZhaoPinHuiCount { get; set; }
        public int ContractMonth { get; set; }
        public string? HiresCount { get; set; }
        /// <summary>
        /// 0 未生成 1已完成 2已生成
        /// </summary>
        public int OrderStatus { get; set; }
        public int PartTimePositoin { get; set; }
        public int ReflashCount { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmAd
    {
        public int AdId { get; set; }
        public DateTime StartDate { get; set; }
        public int ValidDay { get; set; }
        public int IsCharge { get; set; }
        public int SumCharge { get; set; }
        public int EplId { get; set; }
        public int? ComId { get; set; }
        public string Company { get; set; } = null!;
        public string? CompanyDescribe { get; set; }
        public int ApplyPlaceId { get; set; }
        public string ApplyWhy { get; set; } = null!;
        public DateTime ApplyDate { get; set; }
        public string? Memo { get; set; }
        public int? CheckMan { get; set; }
        public int CheckMark { get; set; }
        public DateTime? CheckDate { get; set; }
        public string? UnPassWhy { get; set; }
        public DateTime? OnlineDate { get; set; }
        public int? OnlineDay { get; set; }
        public int OnlineMark { get; set; }
        public DateTime? UpLineDate { get; set; }
        public DateTime? DownLineDate { get; set; }
        public bool IsAlter { get; set; }
        public DateTime? AlterDate { get; set; }
        public bool IsDelete { get; set; }
        /// <summary>
        /// 合同编号
        /// </summary>
        public string? Bondno { get; set; }
        public int? MemId { get; set; }
    }
}

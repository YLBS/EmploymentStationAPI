using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewAdNew
    {
        public int AdId { get; set; }
        public int ApplyPlaceId { get; set; }
        public string? PlaceName { get; set; }
        public string Company { get; set; } = null!;
        public int EplId { get; set; }
        public string EplName { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public int ValidDay { get; set; }
        public DateTime ApplyDate { get; set; }
        public int CheckMark { get; set; }
        public string? CheckMemo { get; set; }
        public DateTime? CheckDate { get; set; }
        public int OnlineMark { get; set; }
        public string? OnlineMemo { get; set; }
        public DateTime? OnlineDate { get; set; }
        public int? OnlineDay { get; set; }
        public DateTime? EndlineDate { get; set; }
        public bool IsDelete { get; set; }
        public string? Bondno { get; set; }
        public string? DeleteMemo { get; set; }
        public int? ComId { get; set; }
        public int? CsId { get; set; }
        public string? CsName { get; set; }
        public int? ApplyType { get; set; }
        public int IsCharge { get; set; }
    }
}

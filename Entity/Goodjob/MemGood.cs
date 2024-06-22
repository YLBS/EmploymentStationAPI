using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemGood
    {
        public int GoodsId { get; set; }
        public int GoodsType { get; set; }
        public string Title { get; set; } = null!;
        public int ResumeCount { get; set; }
        public int PosCount { get; set; }
        public int SmsCount { get; set; }
        public int UpdateCount { get; set; }
        public int EffectiveTimeDate { get; set; }
        public double Price { get; set; }
        public int OrderNumber { get; set; }
        public double Discount { get; set; }
        public bool IsDell { get; set; }
        public int HposCount { get; set; }
        public DateTime CreateDate { get; set; }
        public int OrderSort { get; set; }
        public bool IsSingle { get; set; }
        public int PtposCount { get; set; }
        public int PtupdateCount { get; set; }
    }
}

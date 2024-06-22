using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemOrder
    {
        public int OrderId { get; set; }
        public int MemId { get; set; }
        public string OrderString { get; set; } = null!;
        public int OrderType { get; set; }
        public string Title { get; set; } = null!;
        public int ResumeCount { get; set; }
        public int PosCount { get; set; }
        public int SmsCount { get; set; }
        public int UpdateCount { get; set; }
        public int EffectiveTimeDate { get; set; }
        public double Price { get; set; }
        public DateTime OrderTimeDate { get; set; }
        /// <summary>
        /// 1 支付宝 2微信  俊才币
        /// </summary>
        public int PayType { get; set; }
        public int PayState { get; set; }
        public DateTime PayTimeDate { get; set; }
        public string MerchantNumber { get; set; } = null!;
        /// <summary>
        /// 0 待付款 1已付款 完成 2取消
        /// </summary>
        public int OrderState { get; set; }
        public int IsDell { get; set; }
        public int SalerUserId { get; set; }
        public double Discount { get; set; }
        public int GoodsId { get; set; }
        public double OriginalPrice { get; set; }
        public int HposCount { get; set; }
        public int ZphId { get; set; }
        public string? Crmcontract { get; set; }
        public int EplId { get; set; }
        public string? Process { get; set; }
        public DateTime? CrmupDate { get; set; }
        public int SourceId { get; set; }
        public string SourceTable { get; set; } = null!;
        public int PtposCount { get; set; }
        public int PtupdateCount { get; set; }
    }
}

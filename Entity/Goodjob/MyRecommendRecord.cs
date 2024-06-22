using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyRecommendRecord
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public int RecommendId { get; set; }
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 0为初始 1为进 2为出
        /// </summary>
        public int Rtype { get; set; }
        /// <summary>
        /// 0未知 1注册 100提现
        /// </summary>
        public int Source { get; set; }
        public int Amount { get; set; }
        /// <summary>
        /// 是否有效 0 否 1是
        /// </summary>
        public bool? IsEffective { get; set; }
        public string? Tansfers { get; set; }
        public string? PartnerTradeNo { get; set; }
    }
}

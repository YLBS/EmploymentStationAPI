using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class MemPosSpotRecord
    {
        public int Id { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 点数
        /// </summary>
        public int Spot { get; set; }
        /// <summary>
        /// 点数类型 0为充值 1为消费
        /// </summary>
        public int SpotType { get; set; }
        public DateTime CreatTime { get; set; }
        /// <summary>
        /// 订单编号
        /// </summary>
        public string? OrderNumber { get; set; }
    }
}

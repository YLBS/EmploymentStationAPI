using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ZphReserve
    {
        public int Id { get; set; }
        public int ReserveNumber { get; set; }
        public int ZphId { get; set; }
        /// <summary>
        /// 0 为 尚未使用
        /// </summary>
        public bool IsUse { get; set; }
    }
}

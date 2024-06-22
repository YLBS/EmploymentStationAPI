using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmComCount
    {
        public int Id { get; set; }
        public int EplId { get; set; }
        public int ComCount { get; set; }
        /// <summary>
        /// 1 未成交  2过期库
        /// </summary>
        public int Csid { get; set; }
    }
}

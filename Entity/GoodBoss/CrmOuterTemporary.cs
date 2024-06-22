using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    /// <summary>
    /// 外网企业更新公库
    /// </summary>
    public partial class CrmOuterTemporary
    {
        public int ComId { get; set; }
        public DateTime OuterRefleshDate { get; set; }
        public DateTime InputDate { get; set; }
        public string FromSite { get; set; } = null!;
        public int PosCount { get; set; }
        public string OuterSiteUrl { get; set; } = null!;
        public bool IsFree { get; set; }
        /// <summary>
        /// 最后拜访人
        /// </summary>
        public int LastLinkEplId { get; set; }
        public int Id { get; set; }
        public int IsNewInput { get; set; }
        public int HasContact { get; set; }
        public string NewestPosName { get; set; } = null!;
        public DateTime? NewestReflashDate { get; set; }
        public int MouthReflashCount { get; set; }
    }
}

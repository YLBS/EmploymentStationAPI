using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusInvite
    {
        public int Id { get; set; }
        /// <summary>
        /// 发起人
        /// </summary>
        public int SponsorId { get; set; }
        /// <summary>
        /// 响应人
        /// </summary>
        public int ResponseId { get; set; }
        public int CampusId { get; set; }
        /// <summary>
        /// getdate()
        /// </summary>
        public DateTime AddDateTime { get; set; }
        public int PosId { get; set; }
        public int SigId { get; set; }
        public int CampusMemId { get; set; }
        /// <summary>
        /// 0未选 1可以 2不行 3需复试
        /// </summary>
        public int IsOk { get; set; }
        public int IsBrowse { get; set; }
    }
}

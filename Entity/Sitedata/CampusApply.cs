using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusApply
    {
        public int Id { get; set; }
        public int CampusId { get; set; }
        public int ResumeId { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public DateTime AddDateTime { get; set; }
        /// <summary>
        /// 0未选 1可以 2不行 3需复试
        /// </summary>
        public int IsOk { get; set; }
        public int SigId { get; set; }
        public int IsBrowse { get; set; }
    }
}

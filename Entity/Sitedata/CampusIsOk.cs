using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusIsOk
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public int PosId { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 0未选 1可以 2不行
        /// </summary>
        public int IsOk { get; set; }
        public int CampusId { get; set; }
        public DateTime AddDateTime { get; set; }
        public string? OpenId { get; set; }
        /// <summary>
        /// 1是应聘 2是邀约
        /// </summary>
        public int Type { get; set; }
        public int RecordId { get; set; }
    }
}

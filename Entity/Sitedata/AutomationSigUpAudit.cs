using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class AutomationSigUpAudit
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        /// <summary>
        /// 0尚未 1审核通过 2审核未通过
        /// </summary>
        public int Audit { get; set; }
        public int CampusZpId { get; set; }
        public DateTime Datetime { get; set; }
        public int ZphNumber { get; set; }
        public bool IsMake { get; set; }
    }
}

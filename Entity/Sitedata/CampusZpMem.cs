using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusZpMem
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public string ZphNumber { get; set; } = null!;
        public string MemName { get; set; } = null!;
        public string PosName { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public DateTime AddDateTime { get; set; }
        public int Sequence { get; set; }
        public string OpenId { get; set; } = null!;
        public int CampusZpId { get; set; }
        public string ContactPhone { get; set; } = null!;
        public string ContactEmail { get; set; } = null!;
        public int UserId { get; set; }
        public int Audit { get; set; }
        public int ComId { get; set; }
        public DateTime? SignUpDate { get; set; }
        /// <summary>
        /// 1报名  2入场
        /// </summary>
        public int SignState { get; set; }
        public int BrowseCount { get; set; }
    }
}

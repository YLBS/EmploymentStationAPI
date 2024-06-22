using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusZpSinUpBack
    {
        public int Cid { get; set; }
        public string Cname { get; set; } = null!;
        public string Cphone { get; set; } = null!;
        public string CjobId { get; set; } = null!;
        public string CjobValue { get; set; } = null!;
        public DateTime? SignUpDate { get; set; }
        public DateTime? EntranceDate { get; set; }
        public DateTime AddDate { get; set; }
        /// <summary>
        /// 1报名  2入场
        /// </summary>
        public int State { get; set; }
        public int ZphId { get; set; }
        public string Openid { get; set; } = null!;
        public int SigCount { get; set; }
        public string CjobMaxId { get; set; } = null!;
    }
}

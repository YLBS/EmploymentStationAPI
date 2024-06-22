using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphConfereeMem
    {
        public int ConfereeId { get; set; }
        public int Pid { get; set; }
        public int MemId { get; set; }
        public DateTime AddDateTime { get; set; }
        public int StallNum { get; set; }
        public int CheckFlag { get; set; }
        public string MemName { get; set; } = null!;
        public bool IsOnline { get; set; }
        public DateTime SignDate { get; set; }
        public string Remark { get; set; } = null!;
        public bool Pconline { get; set; }
        public DateTime PconlineDate { get; set; }
        public DateTime CheckDate { get; set; }
        public string Region { get; set; } = null!;
        public int SendSms { get; set; }
        public DateTime? Ssmsdate { get; set; }
        public int IsZjopen { get; set; }
        public int SignCount { get; set; }
        /// <summary>
        /// 是否校企
        /// </summary>
        public int IsSchool { get; set; }
        public DateTime NewCheckDate { get; set; }
        public string? SchoolName { get; set; }
    }
}

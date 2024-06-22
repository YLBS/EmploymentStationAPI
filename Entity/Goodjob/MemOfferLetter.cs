using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemOfferLetter
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public string PosName { get; set; } = null!;
        public string MemAddress { get; set; } = null!;
        public string ContactInfo { get; set; } = null!;
        public string OfferMidleContent { get; set; } = null!;
        public string Salary { get; set; } = null!;
        public string WorkHours { get; set; } = null!;
        /// <summary>
        /// 报到时间1
        /// </summary>
        public string ReportTime { get; set; } = null!;
        /// <summary>
        /// 报到时间2
        /// </summary>
        public string ReportDay { get; set; } = null!;
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime SendTime { get; set; }
        public int MyUserId { get; set; }
    }
}

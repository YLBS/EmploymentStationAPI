using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmAicallRecord
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public string RequestPhone { get; set; } = null!;
        public int CustomerId { get; set; }
        /// <summary>
        /// 录音地址
        /// </summary>
        public string RecordUrl { get; set; } = null!;
        public string CallRecord { get; set; } = null!;
        public DateTime RequestDate { get; set; }
        public DateTime CallBackDate { get; set; }
    }
}

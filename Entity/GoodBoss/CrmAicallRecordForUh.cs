using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    /// <summary>
    /// 优呼AI通话回调记录
    /// </summary>
    public partial class CrmAicallRecordForUh
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public string RequestPhone { get; set; } = null!;
        /// <summary>
        /// 回调标识
        /// </summary>
        public string LocaId { get; set; } = null!;
        public int TouchPhoneId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime CallBackDate { get; set; }
        public string TalkText { get; set; } = null!;
        public int ConversationTime { get; set; }
        public string ContactPerson { get; set; } = null!;
        public int TalkCount { get; set; }
    }
}

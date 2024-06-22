using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewCrmAicallRecordForUh
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public int EplId { get; set; }
        public string RequestPhone { get; set; } = null!;
        public string LocaId { get; set; } = null!;
        public int TouchPhoneId { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime CallBackDate { get; set; }
        public string TalkText { get; set; } = null!;
        public int ConversationTime { get; set; }
        public string ContactPerson { get; set; } = null!;
        public int TalkCount { get; set; }
        public string? EplName { get; set; }
        public string? ComName { get; set; }
    }
}

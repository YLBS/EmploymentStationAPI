using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubMessage
    {
        public int MessageId { get; set; }
        public int MemId { get; set; }
        public int PosId { get; set; }
        public int MyUserId { get; set; }
        public string MessageString { get; set; } = null!;
        public DateTime MessageTime { get; set; }
        public bool IsRead { get; set; }
        /// <summary>
        /// 1 My 2 Hr
        /// </summary>
        public int MessageType { get; set; }
    }
}

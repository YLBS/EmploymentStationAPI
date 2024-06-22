using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class PubImRoamingLog
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public int MyUserId { get; set; }
        /// <summary>
        /// 消息方向，即该消息是企业发送的还是接收的：1 发送,2 接收
        /// </summary>
        public int Direction { get; set; }
        /// <summary>
        /// 消息时间
        /// </summary>
        public DateTime InsertTime { get; set; }
    }
}

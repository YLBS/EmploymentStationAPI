using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MessageRecord
    {
        public int Id { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string? SenderPhone { get; set; }
        /// <summary>
        /// 上行的目标号
        /// </summary>
        public string? Target { get; set; }
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? Uptime { get; set; }
        /// <summary>
        /// 发送内容
        /// </summary>
        public string? Msg { get; set; }
        /// <summary>
        /// 对应的下行内容
        /// </summary>
        public string? Mt { get; set; }
    }
}

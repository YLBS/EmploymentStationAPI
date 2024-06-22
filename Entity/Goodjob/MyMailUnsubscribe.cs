using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    /// <summary>
    /// 求职者邮件退订
    /// </summary>
    public partial class MyMailUnsubscribe
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        /// <summary>
        /// 退订类型，1：录用通知退订
        /// </summary>
        public int UnsubscribeType { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime AddDateTime { get; set; }
    }
}

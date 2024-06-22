using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyResumeZphReceipt
    {
        public int MyUserId { get; set; }
        /// <summary>
        /// 微信回执
        /// </summary>
        public int WxReceipt { get; set; }
        /// <summary>
        /// 短信回执
        /// </summary>
        public int Smsreceipt { get; set; }
        public DateTime? WxReceiptTime { get; set; }
        public DateTime? SmsreceiptTime { get; set; }
    }
}

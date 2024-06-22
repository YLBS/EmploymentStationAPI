using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyPush
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        /// <summary>
        /// 1。版本更新 2 面试邀请通知 3 简历查看通知 4招聘会通知
        /// </summary>
        public int PushType { get; set; }
        public int PushStatus { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}

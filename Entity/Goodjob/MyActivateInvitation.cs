using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MyActivateInvitation
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        public bool IsRespond { get; set; }
        public DateTime SendDateTime { get; set; }
        public DateTime? RespondDateTime { get; set; }
        /// <summary>
        /// 0 邀请激活 1 简历信息完善 2职位投诉 3职位推荐
        /// </summary>
        public int Type { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 发送累计次数 用于职位推荐
        /// </summary>
        public int SendCount { get; set; }
        public int RecordId { get; set; }
        /// <summary>
        /// 退订 0位默认1为退订
        /// </summary>
        public bool Unsubscribe { get; set; }
    }
}

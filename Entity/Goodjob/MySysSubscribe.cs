using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MySysSubscribe
    {
        public int Id { get; set; }
        public int MyUserId { get; set; }
        /// <summary>
        /// 小程序帐号ID
        /// </summary>
        public string ToUserName { get; set; } = null!;
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 用户openid
        /// </summary>
        public string FromUserName { get; set; } = null!;
        /// <summary>
        /// 模板id（一次订阅可能有多个id）
        /// </summary>
        public string TemplateId { get; set; } = null!;
        /// <summary>
        /// 订阅结果（accept接收；reject拒收）
        /// </summary>
        public string SubscribeStatusString { get; set; } = null!;
        /// <summary>
        /// 弹框场景，0代表在小程序页面内
        /// </summary>
        public string PopupScene { get; set; } = null!;
        /// <summary>
        /// 1 新职位发布 2 收到面试邀请通知 3简历被下载 4简历被游览
        /// </summary>
        public int SubType { get; set; }
    }
}

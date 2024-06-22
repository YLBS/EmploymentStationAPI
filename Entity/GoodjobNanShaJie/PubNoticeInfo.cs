using System;
using System.Collections.Generic;

namespace Entity.GoodjobNanShaJie
{
    public partial class PubNoticeInfo
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        /// <summary>
        /// 通知类型 0位所有 1为企业 2为个人
        /// </summary>
        public int Type { get; set; }
        public string Title { get; set; } = null!;
        public string Ncontent { get; set; } = null!;
        /// <summary>
        /// 是否读取
        /// </summary>
        public bool IsRead { get; set; }
        public DateTime CreatTime { get; set; }
        public DateTime? ReadTime { get; set; }
    }
}

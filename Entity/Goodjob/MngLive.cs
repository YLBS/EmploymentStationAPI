using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MngLive
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string LiveUrl { get; set; } = null!;
        public string LiveUrl2 { get; set; } = null!;
        public string H5StartPatch { get; set; } = null!;
        public string WxTitle { get; set; } = null!;
        public string WxImage { get; set; } = null!;
        public int FollowNumber { get; set; }
        public bool IsPlay { get; set; }
        public DateTime? PlayDateTime { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string WxDesc { get; set; } = null!;
        public string? WxUrl { get; set; }
        public string? LocalPath { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string? Briefing { get; set; }
        public bool? IsDell { get; set; }
        public int? CommentCount { get; set; }
        public int? PlayCount { get; set; }
        public int? ClickCount { get; set; }
        public int? FabulousCount { get; set; }
        public bool IsTop { get; set; }
        public int Scale { get; set; }
        public string ShowWay { get; set; } = null!;
        public int ZphId { get; set; }
        public string LiveUrl1 { get; set; } = null!;
        /// <summary>
        /// 直播介绍
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// 发布渠道 1 自我 2 小程序
        /// </summary>
        public string PushShowWay { get; set; } = null!;
        /// <summary>
        /// 预告图片
        /// </summary>
        public string PreviewImg { get; set; } = null!;
        /// <summary>
        /// 开启弹幕
        /// </summary>
        public bool OpenBarrage { get; set; }
        /// <summary>
        /// 开启留言
        /// </summary>
        public bool OpenMassage { get; set; }
        /// <summary>
        /// 回放地址
        /// </summary>
        public string PlayBackUrl { get; set; } = null!;
        public string CustomerServiceImg { get; set; } = null!;
        public string AnchorName { get; set; } = null!;
        public bool LivePlayOpenFlow { get; set; }
        public bool OpenLottery { get; set; }
        public string LotteryTime { get; set; } = null!;
        public int Esid { get; set; }
    }
}

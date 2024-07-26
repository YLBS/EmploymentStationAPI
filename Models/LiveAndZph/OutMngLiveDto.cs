using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.LiveAndZph
{
    public class OutMngLiveDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string LiveUrl { get; set; } = null!;
        public string LiveUrl2 { get; set; } = null!;
        public string WxTitle { get; set; } = null!;
        public string WxImage { get; set; } = null!;
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

        public string PushShowWayStr
        {
            get
            {
                if (PushShowWay == "1") return "自有频道";
                if (PushShowWay == "2") return "小程序";
                return "";
            }
        }

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
        /// <summary>
        /// 驿站ID
        /// </summary>
        public int Esid { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZhaoPinHuiImage
    {
        /// <summary>
        /// 自增ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 文章ID
        /// </summary>
        public int Pid { get; set; }
        /// <summary>
        /// 缩略图地址
        /// </summary>
        public string Thumbpath { get; set; } = null!;
        /// <summary>
        /// 原图地址
        /// </summary>
        public string Originalpath { get; set; } = null!;
        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime Addtime { get; set; }
    }
}

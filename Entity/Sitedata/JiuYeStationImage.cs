using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class JiuYeStationImage
    {
        public int Id { get; set; }
        /// <summary>
        /// 驿站ID
        /// </summary>
        public int Esid { get; set; }
        public string ImageUrl { get; set; } = null!;
        /// <summary>
        /// 0 1顶部 2列表图片 3环境
        /// </summary>
        public int ImageType { get; set; }
        public DateTime UpImageDate { get; set; }
    }
}

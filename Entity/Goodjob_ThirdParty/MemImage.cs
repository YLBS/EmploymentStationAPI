using System;
using System.Collections.Generic;

namespace Entity.Goodjob_ThirdParty
{
    public partial class MemImage
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 图片类型 0为logo 1为环境
        /// </summary>
        public int Type { get; set; }
        public string FilePath { get; set; } = null!;
        public DateTime CreateTime { get; set; }
        public int CheckStatus { get; set; }
        public DateTime? CheckDate { get; set; }
        public DateTime? UpTime { get; set; }
        public int? ContentLength { get; set; }
        public string? ContentType { get; set; }
    }
}

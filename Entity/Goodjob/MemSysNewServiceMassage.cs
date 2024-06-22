using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemSysNewServiceMassage
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Url { get; set; } = null!;
        /// <summary>
        /// 用于是否 加红以及 加上最新图片
        /// </summary>
        public bool IsStamp { get; set; }
        public DateTime? UpDateTime { get; set; }
        public DateTime AddDateTime { get; set; }
        public bool IsShow { get; set; }
    }
}

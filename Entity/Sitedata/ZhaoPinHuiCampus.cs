using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZhaoPinHuiCampus
    {
        public int Pid { get; set; }
        public string Title { get; set; } = null!;
        public string Scale { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Logo { get; set; } = null!;
        public string Hostunit { get; set; } = null!;
        public string Details { get; set; } = null!;
        public DateTime BenigDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int HotCount { get; set; }
        /// <summary>
        /// 0 显示  删除
        /// </summary>
        public byte ClassType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class ZphConfereeMemPoster
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public int MemId { get; set; }
        /// <summary>
        /// 是否可以 0 待定 1可以 2不行
        /// </summary>
        public int IsOk { get; set; }
        public string Poster { get; set; } = null!;
        public string Remarks { get; set; } = null!;
        public int IsSend { get; set; }
        public DateTime AddDateTime { get; set; }
        public string PosterUrl { get; set; } = null!;
        public DateTime? SendDateTime { get; set; }
        public DateTime? RdateTime { get; set; }
    }
}

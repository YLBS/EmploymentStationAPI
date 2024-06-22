using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemLoginLog
    {
        public int Id { get; set; }
        public int MemId { get; set; }
        public DateTime LoginDate { get; set; }
        /// <summary>
        /// 1电脑 2手机浏览器  3安卓手机 4苹果手机 5小程序
        /// </summary>
        public int LoginType { get; set; }
        public string UserName { get; set; } = null!;
        public string LoginIp { get; set; } = null!;
    }
}

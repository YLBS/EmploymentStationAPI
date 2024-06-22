using System;
using System.Collections.Generic;

namespace Entity.Sitedata
{
    public partial class CampusAdmin
    {
        public int AdminId { get; set; }
        public string UserName { get; set; } = null!;
        public string PassWord { get; set; } = null!;
        public string Title { get; set; } = null!;
        public bool IsAdmin { get; set; }
        /// <summary>
        /// 设定 处理限时
        /// </summary>
        public int Time { get; set; }
    }
}

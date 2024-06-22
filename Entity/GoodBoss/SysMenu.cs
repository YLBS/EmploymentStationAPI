using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class SysMenu
    {
        public int MnuId { get; set; }
        public int ParentId { get; set; }
        public int Depth { get; set; }
        public int Sequence { get; set; }
        public string MnuName { get; set; } = null!;
        public string? Alias { get; set; }
        public string? LnkUrl { get; set; }
        public string? Memo { get; set; }
        /// <summary>
        /// 外网简历管理：1表示页面，2表示按钮
        /// </summary>
        public short MnuType { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool IsBlank { get; set; }
        public bool IsShowTouch { get; set; }
        public string TouchWebPath { get; set; } = null!;
        public string TouchImagePath { get; set; } = null!;
    }
}

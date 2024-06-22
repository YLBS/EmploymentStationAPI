using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PeiFileType
    {
        /// <summary>
        /// //菜单编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 父ID,无父ID用0表示
        /// </summary>
        public string? ParentId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string PtypeName { get; set; } = null!;
        /// <summary>
        /// 备注
        /// </summary>
        public string? Memo { get; set; }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime? InTime { get; set; }
    }
}

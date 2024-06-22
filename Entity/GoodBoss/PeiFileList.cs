using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class PeiFileList
    {
        /// <summary>
        /// //自动编号
        /// </summary>
        public int FileId { get; set; }
        /// <summary>
        /// //文件编号
        /// </summary>
        public string FileNo { get; set; } = null!;
        /// <summary>
        /// 文件标题
        /// </summary>
        public string FileName { get; set; } = null!;
        /// <summary>
        /// 备注
        /// </summary>
        public string ShortMemo { get; set; } = null!;
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath { get; set; } = null!;
        /// <summary>
        /// 文件类型
        /// </summary>
        public byte FileType { get; set; }
        public string ExpandType { get; set; } = null!;
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime InTime { get; set; }
        /// <summary>
        /// 是谁发布的内容
        /// </summary>
        public int EplId { get; set; }
        public string? EplName { get; set; }
        public string? PosName { get; set; }
        /// <summary>
        /// 点击次数
        /// </summary>
        public int InNumber { get; set; }
        /// <summary>
        /// 是否被删除
        /// </summary>
        public bool DelFlag { get; set; }
    }
}

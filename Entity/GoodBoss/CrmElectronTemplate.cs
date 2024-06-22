using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmElectronTemplate
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int EtId { get; set; }
        /// <summary>
        /// 模板名
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// 正文
        /// </summary>
        public string? Body { get; set; }
        /// <summary>
        /// 所属人
        /// </summary>
        public int? EplId { get; set; }
        /// <summary>
        /// 所属姓名
        /// </summary>
        public string? EplName { get; set; }
        /// <summary>
        /// 录入时间
        /// </summary>
        public DateTime? InTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public short? State { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public short? Type { get; set; }
        /// <summary>
        /// 备1
        /// </summary>
        public int? Int1 { get; set; }
        /// <summary>
        /// 备2
        /// </summary>
        public string? Str1 { get; set; }
    }
}

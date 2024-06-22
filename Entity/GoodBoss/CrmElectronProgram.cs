using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class CrmElectronProgram
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int EleId { get; set; }
        /// <summary>
        /// 客户编号
        /// 
        /// </summary>
        public int? ComId { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        public string? ComName { get; set; }
        /// <summary>
        /// 申请人编号
        /// </summary>
        public int? EplId { get; set; }
        /// <summary>
        /// 申请人姓名
        /// </summary>
        public string? EplName { get; set; }
        /// <summary>
        /// 部门编号
        /// </summary>
        public int? DptId { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string? DptName { get; set; }
        /// <summary>
        /// 正文
        /// </summary>
        public string? Content { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public short? State { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool? IsSuccess { get; set; }
        /// <summary>
        /// 是否接收
        /// </summary>
        public bool? IsReceive { get; set; }
        /// <summary>
        /// 接收人电话
        /// </summary>
        public string? Phone { get; set; }
        /// <summary>
        /// 接收人邮箱
        /// </summary>
        public string? ReceiveEmail { get; set; }
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime? ApplyTime { get; set; }
        /// <summary>
        /// 录入日期
        /// </summary>
        public DateTime? InTime { get; set; }
        /// <summary>
        /// 备1
        /// </summary>
        public int? Int1 { get; set; }
        /// <summary>
        /// 备2
        /// </summary>
        public string? Str1 { get; set; }
        public string? SendName { get; set; }
    }
}

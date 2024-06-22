using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class FinInvoice
    {
        public int InId { get; set; }
        /// <summary>
        /// 企业编号
        /// </summary>
        public int ComId { get; set; }
        /// <summary>
        /// 公司类别（番禺或南沙）
        /// </summary>
        public int ComType { get; set; }
        /// <summary>
        /// 发票类型
        /// </summary>
        public int InType { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string ComName { get; set; } = null!;
        /// <summary>
        /// 纳税人识别号
        /// </summary>
        public string Taxpayers { get; set; } = null!;
        /// <summary>
        /// 开票金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 对公账号
        /// </summary>
        public string BroughtAccount { get; set; } = null!;
        /// <summary>
        /// 开户行
        /// </summary>
        public string OpenAccount { get; set; } = null!;
        /// <summary>
        /// 公司地址
        /// </summary>
        public string Address { get; set; } = null!;
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; } = null!;
        /// <summary>
        /// 类型（填写招聘会或网络会员）
        /// </summary>
        public int UseType { get; set; }
        /// <summary>
        /// 数量（填写招聘会场次或会员时间）
        /// </summary>
        public string Remark { get; set; } = null!;
        /// <summary>
        /// 申请人编号
        /// </summary>
        public int EplId { get; set; }
        /// <summary>
        /// 申请状态（0 未审核 -1 审核不通过 1申请通过 ）
        /// </summary>
        public int InState { get; set; }
        /// <summary>
        /// 申请修改（通过状态下  1 为申请修改  2 为同意修改 3为领取）
        /// </summary>
        public int InModify { get; set; }
        /// <summary>
        /// 不通过原因
        /// </summary>
        public string? StateContext { get; set; }
        /// <summary>
        /// 开具发票（开具后输入发票号码）
        /// </summary>
        public string InNum { get; set; } = null!;
        /// <summary>
        /// 申请时间
        /// </summary>
        public DateTime AddTime { get; set; }
        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AuditTime { get; set; }
        public bool IsWeXin { get; set; }
        public DateTime? NumTime { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public int IsReceipt { get; set; }
    }
}

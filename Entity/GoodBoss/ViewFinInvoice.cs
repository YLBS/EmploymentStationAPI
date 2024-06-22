using System;
using System.Collections.Generic;

namespace Entity.GoodBoss
{
    public partial class ViewFinInvoice
    {
        public int InId { get; set; }
        public int ComId { get; set; }
        public int ComType { get; set; }
        public int InType { get; set; }
        public string ComName { get; set; } = null!;
        public string Taxpayers { get; set; } = null!;
        public decimal Amount { get; set; }
        public string BroughtAccount { get; set; } = null!;
        public string OpenAccount { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int UseType { get; set; }
        public string Remark { get; set; } = null!;
        public int EplId { get; set; }
        public int InState { get; set; }
        public int InModify { get; set; }
        public string? StateContext { get; set; }
        public string InNum { get; set; } = null!;
        public DateTime AddTime { get; set; }
        public DateTime AuditTime { get; set; }
        public string EplName { get; set; } = null!;
        public DateTime? NumTime { get; set; }
        public int DptId { get; set; }
        public int Expr1 { get; set; }
        public string? DptName { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public int IsReceipt { get; set; }
    }
}

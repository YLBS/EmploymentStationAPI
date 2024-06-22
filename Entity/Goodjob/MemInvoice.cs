using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemInvoice
    {
        public int Id { get; set; }
        public string? MemName { get; set; }
        public string? BankAccount { get; set; }
        public string? CreditCode { get; set; }
        public string? MemAddress { get; set; }
        public string? ContactPerson { get; set; }
        public string? ContactPhone { get; set; }
        public string? Email { get; set; }
        /// <summary>
        /// 发票类型  1普票（电子）   2 专票（纸质）
        /// </summary>
        public int? InvoceType { get; set; }
        public string? InvoceTypeName { get; set; }
        public int? ZphId { get; set; }
        public int? MemId { get; set; }
        public int? IsDell { get; set; }
    }
}

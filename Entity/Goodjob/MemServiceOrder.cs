using System;
using System.Collections.Generic;

namespace Entity.Goodjob
{
    public partial class MemServiceOrder
    {
        public int OrderId { get; set; }
        public int MemId { get; set; }
        public int ItemId { get; set; }
        public int ValidDay { get; set; }
        public string Detail { get; set; } = null!;
        public string ApplyPerson { get; set; } = null!;
        public DateTime ApplyDate { get; set; }
        public byte DoFlag { get; set; }
        public string? DoUserId { get; set; }
        public DateTime? DoDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
